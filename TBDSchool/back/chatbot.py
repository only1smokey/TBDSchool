import random
import json
import numpy as np
import pickle

import sys

import nltk
from nltk.stem import WordNetLemmatizer

from tensorflow import keras
from keras.models import load_model

lemmatizer = WordNetLemmatizer()
data_file = "intents.json"

input_str = sys.argv[1]

with open(data_file, 'r') as file:
    intents = json.load(file)

words = pickle.load(open("words.pkl", "rb"))
classes = pickle.load(open("classes.pkl", "rb"))
model = load_model("chatbot_model.h5")

def clean_up_sentence(sentence):
    sentence_words = nltk.word_tokenize(sentence)
    sentence_words = [lemmatizer.lemmatize(word) for word in sentence_words]
    
    return sentence_words


def bag_of_words(sentence):
    sentence_words = clean_up_sentence(sentence)
    bag = [0] * len(words)
    for w in sentence_words:
        for i, word in enumerate(words):
            if word == w:
                bag[i] = 1
                
    return np.array(bag)

def predict_class(sentence):
    bow = bag_of_words(sentence)
    res = model.predict(np.array([bow]))[0]
    ERROR_THRESHOLD = 0.15
    results = [[i, r] for i ,r in enumerate(res) if r > ERROR_THRESHOLD]
    
    results.sort(key=lambda x: x[1], reverse=True)
    return_list = []
    for r in results:
        return_list.append({'intent': classes[r[0]], 'probability': str(r[1])})
    
    return return_list

def get_response(intents_list, intents_json):
    if len(intents_list) == 0:
        return "Sorry, I don't understand. Can you please rephrase?"
    
    tag = intents_list[0]['intent']
    list_of_intents = intents_json['intents']
    for i in list_of_intents:
        if i['tag'] == tag:
            result = random.choice(i['responses'])
            break
    return result

print("GO! Bot is running!")

#while True:
#    message = input("")
#    ints = predict_class(message)
#    res = get_response(ints, intents)
#    print(res)
#    with open('res.txt', 'w', encoding='utf-8') as res_file:
#        res_file.write(res)
#        res_file.close()


message = input("")
ints = predict_class(message)
res = get_response(ints, intents)
print(res)
with open('res.txt', 'w', encoding='utf-8') as res_file:
    res_file.write(res)
    res_file.close()

