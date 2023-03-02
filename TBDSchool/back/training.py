import nltk
from nltk.stem import WordNetLemmatizer
import numpy as np
import random
import pickle
import json
from tensorflow import keras
from keras.models import Sequential
from keras.layers import Dense, Activation, Dropout
from keras.optimizers import SGD

# Uncomment the following line if you need to download the 'punkt' and 'wordnet' packages
#nltk.download('punkt')
#nltk.download('wordnet')

lemmatizer = WordNetLemmatizer()

def tokenize(sentence):
    return nltk.word_tokenize(sentence)

def stem(word):
    return lemmatizer.lemmatize(word.lower())

def bag_of_words(tokenized_sentence, words):
    sentence_words = [stem(word) for word in tokenized_sentence]
    bag = np.zeros(len(words), dtype=np.float32)
    for idx, word in enumerate(words):
        if word in sentence_words:
            bag[idx] = 1.0
    return bag

def create_model(input_shape, output_shape):
    model = Sequential([
        Dense(128, input_shape=input_shape, activation='relu'),
        Dropout(0.5),
        Dense(64, activation='relu'),
        Dropout(0.5),
        Dense(output_shape, activation='softmax')
    ])
    return model

# Load data from the intents file
with open('intents.json', 'r') as file:
    intents = json.load(file)

# Extract words and classes from the intents file
words = []
classes = []
documents = []
for intent in intents['intents']:
    for pattern in intent['patterns']:
        # Tokenize and stem each pattern
        words_in_pattern = tokenize(pattern)
        words.extend(words_in_pattern)
        stemmed_words_in_pattern = [stem(word) for word in words_in_pattern]
        # Add the pattern and its associated class to the list of documents
        documents.append((stemmed_words_in_pattern, intent['tag']))
        # Add the class to the list of classes
        if intent['tag'] not in classes:
            classes.append(intent['tag'])

# Remove duplicates from the words and classes lists, and sort them
words = sorted(list(set(words)))
classes = sorted(list(set(classes)))

# Create the training data
training = []
output_empty = [0] * len(classes)
for document in documents:
    bag = bag_of_words(document[0], words)
    output_row = list(output_empty)
    output_row[classes.index(document[1])] = 1
    training.append([bag, output_row])

# Shuffle the training data
random.shuffle(training)
training = np.array(training)

# Split the training data into input (X) and output (y) variables
X = list(training[:, 0])
y = list(training[:, 1])

# Define the model
model = create_model(input_shape=(len(X[0]),), output_shape=len(classes))

# Compile the model
sgd = SGD(learning_rate=0.01, momentum=0.9, nesterov=True)
model.compile(loss='categorical_crossentropy', optimizer=sgd, metrics=['accuracy'])

# Train the model
model.fit(np.array(X), np.array(y), epochs=10000000, batch_size=5, verbose=1)

# Save the words and classes to pickle files
with open('words.pkl', 'wb') as file:
    pickle.dump(words, file)

with open('classes.pkl', 'wb') as file:
    pickle.dump(classes, file)

# Save the model to an HDF5 file
model.save('chatbot_model.h5')
