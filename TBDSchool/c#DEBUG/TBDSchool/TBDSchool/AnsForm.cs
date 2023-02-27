using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBDSchool
{

    public partial class AnsForm : Form
    {

        StringBuilder sb = new StringBuilder();
        int currentIndex = 0;
        string fullText = "Dieses Programm kann möglicherweise nicht immer zu 100% korrekte Antworten liefern, da es auf Algorithmen basiert, die auf begrenzten Informationen und vordefinierten Regeln basieren. Die Genauigkeit der Antworten hängt auch von der Qualität der Daten und der Programmierung des Algorithmus ab. Es ist möglich, dass das Programm keine spezifischen Variablen oder unvorhergesehene Ereignisse berücksichtigt, die die Ergebnisse beeinflussen können.";

        public AnsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sb.Append(fullText[currentIndex]);
            LblFact.Text = sb.ToString();
            currentIndex++;

            if (currentIndex == fullText.Length)
            {
                timer1.Enabled = false;
            }
        }

        private void AnsForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
