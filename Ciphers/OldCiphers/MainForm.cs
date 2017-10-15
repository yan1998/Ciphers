using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OldCodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MonoPoliby coder = new MonoPoliby();
                //Выбор режима
                if (radioButton_Code.Checked)
                {
                    //Выбор вида шифрации
                    if (radioButton_Mono.Checked)
                        richTextBox_Out.Text = coder.encodeToMonoCipher(richTextBox_In.Text.ToLower());
                    else
                        richTextBox_Out.Text = coder.encodeToPoliby(coder.encodeToMonoCipher(richTextBox_In.Text.ToLower()));
                }
                else
                {
                    //Выбор вида дешифрации
                    if (radioButton_Mono.Checked)
                        richTextBox_Out.Text = coder.decodeFromMonoCipher(richTextBox_In.Text.ToLower());
                    else
                        richTextBox_Out.Text = coder.decodeFromMonoCipher(coder.decodeFromPoliby(richTextBox_In.Text.ToLower()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
        * Вывод квадрата Полибия
        */
        private void button2_Click(object sender, EventArgs e)
        {
            MonoPoliby coder = new MonoPoliby();
            MessageBox.Show(coder.getPolibySquare(),"Poliby Square");
        }

        /*
         * Чтение текста из файла в текстовое поле
         */
        private void button_Read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string path = open.FileName;
                    richTextBox_In.Text = File.ReadAllText(path,Encoding.Default);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * Очистка текстовых полей
         */
        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_In.Text = String.Empty;
            richTextBox_Out.Text = String.Empty;
        }
    }
}
