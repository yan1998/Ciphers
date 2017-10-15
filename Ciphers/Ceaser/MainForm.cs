using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ceaser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int words = 33;
        private int upperASCII = 1040;
        private int lowerASCII =1072;

        private void comboBox_Language_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_Language.Text == "English")
            {
                this.Text = "Cipher of Caesar";
                groupBox_Coder.Text = "Coder";
                groupBox_Decoder.Text = "Decoder";
                label_CoderText.Text = "Text";
                label_DecoderText.Text = "Text";
                button_CoderClear.Text = "Clear";
                button_DecoderClean.Text = "Clear";
                button_CoderFile.Text = "From file";
                button_DecoderFile.Text = "From file";
                label_CoderResult.Text = "Result";
                label_DecoderResult.Text = "Result";
                button_CoderGo.Text = "Translate";
                button_DecoderGo.Text = "Translate";
                button_DecoderOutFIle.Text = "Write in File";
                button_CoderOutFile.Text = "Write in File";
                //numericUpDown_CoderCount.Maximum = 26;
                //numericUpDown1_DecoderCount.Maximum = 26;
                words = 26;
                upperASCII = 65;
                lowerASCII = 97;
            }
            else
            {
                this.Text = "Шифр Цезаря";
                groupBox_Coder.Text = "Шифратор";
                groupBox_Decoder.Text = "Дешифратор";
                label_CoderText.Text = "Текст";
                label_DecoderText.Text = "Текст";
                button_CoderClear.Text = "Сброс";
                button_DecoderClean.Text = "Сброс";
                button_CoderFile.Text = "Из файла";
                button_DecoderFile.Text = "Из файла";
                label_CoderResult.Text = "Результат";
                label_DecoderResult.Text = "Результат";
                button_CoderGo.Text = "Перевести";
                button_DecoderGo.Text = "Перевести";
                button_DecoderOutFIle.Text = "Записать в файл";
                button_CoderOutFile.Text = "Записать в файл";
                //numericUpDown_CoderCount.Maximum = 33;
                //numericUpDown1_DecoderCount.Maximum = 33;
                words = 33;
                upperASCII = 1040;
                lowerASCII = 1072;
            }
        }

        private void button_CoderClear_Click(object sender, EventArgs e)
        {
            richTextBox_CoderIn.Text = String.Empty;
            richTextBox_CoderOut.Text = String.Empty;
        }

        private void button_DecoderClean_Click(object sender, EventArgs e)
        {
            richTextBox_DecoderIn.Text = String.Empty;
            richTextBox_DecoderOut.Text = String.Empty;
        }

        private void button_CoderFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                    richTextBox_CoderIn.Text = File.ReadAllText(open.FileName, Encoding.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_DecoderFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                    richTextBox_DecoderIn.Text = File.ReadAllText(open.FileName, Encoding.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_CoderGo_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            foreach (char item in richTextBox_CoderIn.Text)
            {
                if (!Char.IsLetter(item))
                {
                    result += item;
                    continue;
                }
                if (Char.IsUpper(item))
                    result += Char.ConvertFromUtf32(upperASCII+(int)(item- upperASCII + numericUpDown_CoderCount.Value%33) % words);
                else
                    result += Char.ConvertFromUtf32(lowerASCII + (int)(item - lowerASCII + numericUpDown_CoderCount.Value%33) % words); 
            }
            richTextBox_CoderOut.Text = result;
        }

        private void button_DecoderGo_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            foreach (char item in richTextBox_DecoderIn.Text)
            {
                if (!Char.IsLetter(item))
                {
                    result += item;
                    continue;
                }
                if (Char.IsUpper(item))
                    result += Char.ConvertFromUtf32(upperASCII + (int)(item - upperASCII - numericUpDown1_DecoderCount.Value%33 + words) % words);
                else
                    result += Char.ConvertFromUtf32(lowerASCII + (int)(item - lowerASCII - numericUpDown1_DecoderCount.Value%33 + words) % words);
            }
            richTextBox_DecoderOut.Text = result;
        }

        private void button_CoderOutFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, richTextBox_CoderOut.Text,Encoding.Unicode);
                    MessageBox.Show("File was saved succesfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_DecoderOutFIle_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, richTextBox_DecoderOut.Text,Encoding.Default);
                    MessageBox.Show("File was saved succesfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown_CoderCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}