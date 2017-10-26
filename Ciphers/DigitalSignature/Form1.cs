using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DigitalSignature
{
    public partial class Form1 : Form
    {
        private string temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 sha = MD5.Create();
            // byte[] b = new byte[3] { 5, 3, 2 };
            using (Stream str2 = new StreamReader("Readme.txt").BaseStream)
            {
                byte[] b1 = sha.ComputeHash(str2);
                string str = "";
                MessageBox.Show(b1.Length.ToString());
                foreach (var item in b1)
                {
                    str += Conversion.Hex(item)+"\n";
                }
                MessageBox.Show(str);            
            } 
        }
        private string Coder(string str,int key)
        {
            string result = String.Empty;
            foreach (char item in str)
            {
                if (!Char.IsLetter(item))
                {
                    result += item;
                    continue;
                }
                if (Char.IsUpper(item))
                    result += Char.ConvertFromUtf32(65 + (int)(item - 65 + key % 26) % 26);
            }
            return result;
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = open.FileName;
            }
        }

        private void Button_Accept_Click(object sender, EventArgs e)
        {
            try
            {
                string[] filename = textBox_Path.Text.Split('.');
                MD5 md5 = MD5.Create();
                string str = "";
                using (Stream stream = new StreamReader(textBox_Path.Text).BaseStream)
                {
                    byte[] bytes = md5.ComputeHash(stream);
                    foreach (var item in bytes)
                        str += Conversion.Hex(item);
                }
                File.Copy(textBox_Path.Text,Coder(str,(int)numericUpDown_CloseKey.Value)+'.'+filename[filename.Length-1]);
                MessageBox.Show($"Файл был успешно подтвержден!\nОткрытый ключ= {26-numericUpDown_CloseKey.Value%26}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Browse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox_Path2.Text = open.FileName;
                temp=open.SafeFileName.Split('.')[0];
            }
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            try
            {
                MD5 md5 = MD5.Create();
                string str = "";
                using (Stream stream = new StreamReader(textBox_Path2.Text).BaseStream)
                {
                    byte[] bytes = md5.ComputeHash(stream);
                    foreach (var item in bytes)
                        str += Conversion.Hex(item);
                }
                if(str== Coder(temp, (int)numericUpDown_OpenKey.Value))
                    MessageBox.Show("Файл проверен!");
                else
                    MessageBox.Show("Файл не проверен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}