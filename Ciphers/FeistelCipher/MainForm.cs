using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeistelCipher
{
    public partial class MainForm : Form
    {
        private List<TextBox> key1 = new List<TextBox>();
        private List<TextBox> key2 = new List<TextBox>();
        private ToPDF pdf = new ToPDF();

        public MainForm()
        {
            InitializeComponent();
            key1.Add((TextBox)Controls["textBox_K10"]);
            key2.Add((TextBox)Controls["textBox_K20"]);
        }

        //Получить первый ключ
        private string GetKey1()
        {
            string result = String.Empty;
            int keySize = (int)numericUpDown_BlockSize.Value / 2;
            for (int i = 0; i < keySize; i++)
                result += this.Controls["textBox_K1" + i].Text;
             return result;
        }

        //Получить второй ключ
        private string GetKey2()
        {
            string result = String.Empty;
            int keySize = (int)numericUpDown_BlockSize.Value / 2;
            for (int i = 0; i < keySize; i++)
                result += this.Controls["textBox_K2" + i].Text;
            return result;
        }

        //Заполнить второй ключ
        private void PutKey2(string key)
        {
            string name = "textBox_K2";
            for (int i = 0; i < key.Length; i++)
                this.Controls[name + i].Text = key[i].ToString();
        }

        //Добавить необходимые пробелы для соответствия размеру блока
        private string AddSpaces(int blockSize)
        {
            string[] text = richTextBox_Input.Text.Split('\n');
            for (int i=0; i < text.Length; i++)
                for (int j = 1; j <= text[i].Length % blockSize; j++)
                    text[i] += ' ';
           return String.Join("\n",text);
        }

        //Предложение размера блока в зависимости от самой короткой строки
        private void button_Propose_Click(object sender, EventArgs e)
        {
            String text = richTextBox_Input.Text;
            if (text.Length < 4)
            {
                MessageBox.Show("Для подсказки необходимо ввести текст по-длиннее!");
                return;
            }
            List<int> proposeSizes = Feistel.BlockSizePropose(text.Split('\n'));
            string proposes = "Оптимальные размеры блока: ";
            foreach (var item in proposeSizes)
                proposes += "\n"+item;
            MessageBox.Show(proposes);
        }

        //динамическое добавление текстовых полей для ввода второго ключа
        private void numericUpDown_BlockSize_ValueChanged(object sender, EventArgs e)
        {
            foreach (var word in key1)
                word.Dispose();
            foreach (var word in key2)
                word.Dispose();
            key1.RemoveAll(t=>true);
            key2.RemoveAll(t => true);
            int keySize = (int)numericUpDown_BlockSize.Value / 2;
            for (int i = 0; i < keySize; i++)
            {
                TextBox t1 = new TextBox();
                t1.Name = $"textBox_K1{i}";
                t1.Size = new Size(24, 20);
                t1.Location = new Point(41+30*i,193);
                t1.KeyPress += textBox_KeyPress;
                key1.Add(t1);
                TextBox t2 = new TextBox();
                t2.Name = $"textBox_K2{i}";
                t2.Size = new Size(24, 20);
                t2.Location = new Point(41 + 30 * i, 260);
                key2.Add(t2);
            }
            Controls.AddRange(key1.ToArray());
            Controls.AddRange(key2.ToArray());
        }

        //Проверка ввода символа в поле ключа
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length > 0 || !Char.IsLetter(e.KeyChar) && e.KeyChar!=' ' && e.KeyChar!='.' && e.KeyChar!=',')
                e.Handled = true;
            if ((Keys)e.KeyChar == Keys.Back)
                e.Handled = false;
        }

        private void radioButton_Reverse_Click(object sender, EventArgs e)
        {
            string key = GetKey1();
            if (key == "")
            {
                MessageBox.Show("Введите первый ключ!");
                radioButton_Reverse.Checked = false;
                return;
            }
            string key2 = key.Reverse();
            PutKey2(key2);
        }

        private void radioButton_Type1_CheckedChanged(object sender, EventArgs e)
        {
            string key = GetKey1();
            if (key == "")
            {
                MessageBox.Show("Введите первый ключ!");
                radioButton_Type1.Checked = false;
                return;
            }
            string key2 = "";
            int half = key.Length / 2;
            key2+=key.Substring(0, half).Reverse();
            key2 += key.Substring(half, half).Reverse();
            PutKey2(key2);
        }

        private void radioButton_Type2_Click(object sender, EventArgs e)
        {
            string key = GetKey1();
            if (key == "")
            {
                MessageBox.Show("Введите первый ключ!");
                radioButton_Type3.Checked = false;
                return;
            }
            string key2 = "";
            key2 += key.Substring(1, key.Length-1);
            key2 += key.Substring(0, 1).Reverse();
            PutKey2(key2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            pdf = new ToPDF();
            string key1 = GetKey1().ToLower(),
                key2=GetKey2().ToLower();
            if (key1 == "" || key2 == "")
            {
                MessageBox.Show("Ключи не могут быть пустыми!");
                return;
            }
            int blockSize = (int)numericUpDown_BlockSize.Value;
            string text=AddSpaces(blockSize).ToLower();
            string[] textarr = text.Split('\n');
            Feistel feistel = new Feistel(GetKey1(),GetKey2(),Language.Russian,pdf);
            richTextBox_Output.Text = String.Empty;
            if(radioButton_Coder.Checked)
                for (int i = 0; i < textarr.Length; i++)
                {
                    for (int j = 0; j < textarr[i].Length; j+=blockSize)
                        richTextBox_Output.Text+=feistel.Coder(textarr[i].Substring(j,blockSize));
                    richTextBox_Output.Text += "\n";
                }
            else
                for (int i = 0; i < textarr.Length; i++)
                {
                    for (int j = 0; j < textarr[i].Length; j += blockSize)
                        richTextBox_Output.Text += feistel.Decoder(textarr[i].Substring(j, blockSize));
                    richTextBox_Output.Text += "\n";
                }
            pdf.OutToPDFFile();
        }
    }
}
