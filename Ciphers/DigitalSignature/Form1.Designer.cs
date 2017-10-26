namespace DigitalSignature
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Accept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_CloseKey = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Path2 = new System.Windows.Forms.TextBox();
            this.button_Browse2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_OpenKey = new System.Windows.Forms.NumericUpDown();
            this.button_Check = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CloseKey)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OpenKey)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 156);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Accept);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericUpDown_CloseKey);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_Path);
            this.tabPage1.Controls.Add(this.button_Browse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Генерация ЭЦП";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(48, 96);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(256, 23);
            this.button_Accept.TabIndex = 5;
            this.button_Accept.Text = "Подтвердить файл электронной подписью";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.Button_Accept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Закрытый ключ: ";
            // 
            // numericUpDown_CloseKey
            // 
            this.numericUpDown_CloseKey.Location = new System.Drawing.Point(191, 70);
            this.numericUpDown_CloseKey.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CloseKey.Name = "numericUpDown_CloseKey";
            this.numericUpDown_CloseKey.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown_CloseKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите файл для подтверждения: ";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(14, 37);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(242, 20);
            this.textBox_Path.TabIndex = 1;
            // 
            // button_Browse
            // 
            this.button_Browse.Location = new System.Drawing.Point(262, 36);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 0;
            this.button_Browse.Text = "Обзор";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Check);
            this.tabPage2.Controls.Add(this.numericUpDown_OpenKey);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button_Browse2);
            this.tabPage2.Controls.Add(this.textBox_Path2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 130);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проверка ЭЦП";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите файл для проверки:";
            // 
            // textBox_Path2
            // 
            this.textBox_Path2.Location = new System.Drawing.Point(19, 30);
            this.textBox_Path2.Name = "textBox_Path2";
            this.textBox_Path2.ReadOnly = true;
            this.textBox_Path2.Size = new System.Drawing.Size(242, 20);
            this.textBox_Path2.TabIndex = 1;
            // 
            // button_Browse2
            // 
            this.button_Browse2.Location = new System.Drawing.Point(267, 29);
            this.button_Browse2.Name = "button_Browse2";
            this.button_Browse2.Size = new System.Drawing.Size(75, 23);
            this.button_Browse2.TabIndex = 2;
            this.button_Browse2.Text = "Обзор";
            this.button_Browse2.UseVisualStyleBackColor = true;
            this.button_Browse2.Click += new System.EventHandler(this.button_Browse2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Открытый ключ:";
            // 
            // numericUpDown_OpenKey
            // 
            this.numericUpDown_OpenKey.Location = new System.Drawing.Point(165, 64);
            this.numericUpDown_OpenKey.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_OpenKey.Name = "numericUpDown_OpenKey";
            this.numericUpDown_OpenKey.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown_OpenKey.TabIndex = 4;
            // 
            // button_Check
            // 
            this.button_Check.Location = new System.Drawing.Point(140, 96);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(75, 23);
            this.button_Check.TabIndex = 5;
            this.button_Check.Text = "Проверить";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 180);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Signature";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CloseKey)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_OpenKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_CloseKey;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Path2;
        private System.Windows.Forms.Button button_Browse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_OpenKey;
        private System.Windows.Forms.Button button_Check;
    }
}

