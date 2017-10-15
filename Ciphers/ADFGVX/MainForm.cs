using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_Code.Checked)
                {
                    Squares s = new Squares();
                    string codeString = s.EncodeToSquaresCipher(richTextBox_Input.Text.ToUpper());
                    MessageBox.Show("Code in 4 Squares Cipher: " + codeString);
                    Adfgvx a = new Adfgvx();
                    richTextBox_Output.Text = a.EncodeToAdfgvx(codeString);
                }
                else
                {
                    Adfgvx a = new Adfgvx();
                    string decodeString = a.DecodeFromAdfgvx(richTextBox_Input.Text.ToUpper());
                    MessageBox.Show("Decode from Adfgvx Cipher: " + decodeString);
                    Squares s = new Squares();
                    richTextBox_Output.Text = s.DecodeFromSquaresCipher(decodeString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adfgvx a = new Adfgvx();
            if(!a.CheckCipher())
                MessageBox.Show("Error!");
            else
                MessageBox.Show(a.ToString(),"ADFGVX table");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Squares s = new Squares();
            MessageBox.Show(s.ToString(),"4 Squares");
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Input.Text = "";
            richTextBox_Output.Text = "";
        }
    }
}
