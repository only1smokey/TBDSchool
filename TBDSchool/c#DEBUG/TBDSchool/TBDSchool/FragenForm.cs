using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBDSchool
{
    public partial class mainForm : Form
    {

        public string PyResult { get; set; }

        private bool isShifted = false;
        public mainForm()
        {
            InitializeComponent();
            

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "!" : "1");

        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "\"" : "2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "§" : "3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "$" : "4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "%" : "5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "&" : "6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "/" : "7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "(" : "8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? ")" : "9");
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "=" : "0");
        }

        private void Btn_q_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Q" : "q");
        }

        private void Btn_w_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "W" : "w");
        }

        private void Btn_e_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "E" : "e");
        }

        private void Btn_r_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "R" : "r");
        }

        private void Btn_t_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "T" : "t");
        }

        private void Btn_Z_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Z" : "z");
        }

        private void Btn_u_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "U" : "u");
        }

        private void Btn_i_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "I" : "i");
        }

        private void Btn_o_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "O" : "o");
        }

        private void Btn_p_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "P" : "p");
        }

        private void Btn_a_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "A" : "a");
        }

        private void Btn_s_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "S" : "s");
        }

        private void Btn_d_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "D" : "d");
        }

        private void Btn_f_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "F" : "f");
        }

        private void Btn_g_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "G" : "g");
        }

        private void Btn_h_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "H" : "h");
        }

        private void Btn_j_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "J" : "j");
        }

        private void Btn_k_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "K" : "k");
        }

        private void Btn_l_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "L" : "l");
        }

        private void Btn_y_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Y" : "y");
        }

        private void Btn_x_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "X" : "x");
        }

        private void Btn_c_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "C" : "c");
        }

        private void Btn_v_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "V" : "v");
        }

        private void Btn_b_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "B" : "b");
        }

        private void Btn_n_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "N" : "n");
        }

        private void Btn_m_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "M" : "m");
        }

        private void bTN_ß_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "?" : "ß");

        }

        private void Btn_oe_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Ö" : "ö");
        }

        private void Btn_ae_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Ä" : "ä");
        }

        private void Btn_ue_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "Ü" : "ü");
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (inputTxtBox.Text.Length > 0)
            {
                // Get the index of the last character in the RichTextBox
                int lastCharIndex = inputTxtBox.Text.Length - 1;

                // Remove the last character from the RichTextBox|
                inputTxtBox.Text = inputTxtBox.Text.Remove(lastCharIndex);
            }
        }

        
        private void Btn_fragen_Click(object sender, EventArgs e)
        {
            string input = inputTxtBox.Text;

            // Call the Python script using subprocess
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "python";
            startInfo.Arguments = "../../../../../back/chatbot.py " + input;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            using (Process process = Process.Start(startInfo))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    // Set the result to the C# textbox
                    PyResult = result;
                    AnsForm ansformm = new AnsForm(PyResult);

                }
            }
            //AnsForm ansform = new AnsForm();
            //ansform.Show();
            //this.Hide();
        }



        private void Btn_dot_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(isShifted ? "," : ".");
        }

        private void Btn_space_Click(object sender, EventArgs e)
        {
            inputTxtBox.AppendText(" ");
        }

        private void Btn_shift_Click(object sender, EventArgs e)
        {
            isShifted = !isShifted;
            if (isShifted)
            {
                Btn_0.Text = "=";
                Btn_1.Text = "!";
                Btn_2.Text = "-";
                Btn_3.Text = "\"";
                Btn_4.Text = "€";
                Btn_5.Text = "%";
                Btn_6.Text = "*";
                Btn_7.Text = "/";
                Btn_8.Text = "(";
                Btn_9.Text = ")";
                Btn_q.Text = "Q";
                Btn_w.Text = "W";
                Btn_e.Text = "E";
                Btn_r.Text = "R";
                Btn_t.Text = "T";
                Btn_Z.Text = "Z";
                Btn_u.Text = "U";
                Btn_i.Text = "I";
                Btn_o.Text = "O";
                Btn_p.Text = "P";
                Btn_a.Text = "A";
                Btn_s.Text = "S";
                Btn_d.Text = "D";
                Btn_f.Text = "F";
                Btn_g.Text = "G";
                Btn_h.Text = "H";
                Btn_j.Text = "J";
                Btn_k.Text = "K";
                Btn_l.Text = "L";
                Btn_y.Text = "Y";
                Btn_x.Text = "X";
                Btn_c.Text = "C";
                Btn_v.Text = "V";
                Btn_b.Text = "B";
                Btn_n.Text = "N";
                Btn_m.Text = "M";
                Btn_oe.Text = "Ö";
                Btn_ae.Text = "Ä";
                Btn_ue.Text = "Ü";
                bTN_ß.Text = "?";
                Btn_dot.Text = ",";
            }
            else
            {
                Btn_0.Text = "0";
                Btn_1.Text = "1";
                Btn_2.Text = "2";
                Btn_3.Text = "3";
                Btn_4.Text = "4";
                Btn_5.Text = "5";
                Btn_6.Text = "6";
                Btn_7.Text = "7";
                Btn_8.Text = "8";
                Btn_9.Text = "9";
                Btn_q.Text = "q";
                Btn_w.Text = "w";
                Btn_e.Text = "e";
                Btn_r.Text = "r";
                Btn_t.Text = "t";
                Btn_Z.Text = "z";
                Btn_u.Text = "u";
                Btn_i.Text = "i";
                Btn_o.Text = "o";
                Btn_p.Text = "p";
                Btn_a.Text = "a";
                Btn_s.Text = "s";
                Btn_d.Text = "d";
                Btn_f.Text = "f";
                Btn_g.Text = "g";
                Btn_h.Text = "h";
                Btn_j.Text = "j";
                Btn_k.Text = "k";
                Btn_l.Text = "l";
                Btn_y.Text = "y";
                Btn_x.Text = "x";
                Btn_c.Text = "c";
                Btn_v.Text = "v";
                Btn_b.Text = "b";
                Btn_n.Text = "n";
                Btn_m.Text = "m";
                bTN_ß.Text = "ß";
                Btn_oe.Text = "ö";
                Btn_ae.Text = "ä";
                Btn_ue.Text = "ü";
                Btn_dot.Text = ".";
            }
        }
    }
}
