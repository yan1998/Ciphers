namespace Ceaser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.groupBox_Coder = new System.Windows.Forms.GroupBox();
            this.button_CoderOutFile = new System.Windows.Forms.Button();
            this.button_CoderGo = new System.Windows.Forms.Button();
            this.numericUpDown_CoderCount = new System.Windows.Forms.NumericUpDown();
            this.button_CoderClear = new System.Windows.Forms.Button();
            this.button_CoderFile = new System.Windows.Forms.Button();
            this.label_CoderResult = new System.Windows.Forms.Label();
            this.label_CoderText = new System.Windows.Forms.Label();
            this.richTextBox_CoderOut = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CoderIn = new System.Windows.Forms.RichTextBox();
            this.groupBox_Decoder = new System.Windows.Forms.GroupBox();
            this.button_DecoderOutFIle = new System.Windows.Forms.Button();
            this.button_DecoderGo = new System.Windows.Forms.Button();
            this.numericUpDown1_DecoderCount = new System.Windows.Forms.NumericUpDown();
            this.button_DecoderClean = new System.Windows.Forms.Button();
            this.button_DecoderFile = new System.Windows.Forms.Button();
            this.label_DecoderResult = new System.Windows.Forms.Label();
            this.label_DecoderText = new System.Windows.Forms.Label();
            this.richTextBox_DecoderOut = new System.Windows.Forms.RichTextBox();
            this.richTextBox_DecoderIn = new System.Windows.Forms.RichTextBox();
            this.groupBox_Coder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoderCount)).BeginInit();
            this.groupBox_Decoder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_DecoderCount)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.comboBox_Language.Location = new System.Drawing.Point(268, 12);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Language.TabIndex = 0;
            this.comboBox_Language.Text = "Русский";
            this.comboBox_Language.SelectedValueChanged += new System.EventHandler(this.comboBox_Language_SelectedValueChanged);
            // 
            // groupBox_Coder
            // 
            this.groupBox_Coder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Coder.Controls.Add(this.button_CoderOutFile);
            this.groupBox_Coder.Controls.Add(this.button_CoderGo);
            this.groupBox_Coder.Controls.Add(this.numericUpDown_CoderCount);
            this.groupBox_Coder.Controls.Add(this.button_CoderClear);
            this.groupBox_Coder.Controls.Add(this.button_CoderFile);
            this.groupBox_Coder.Controls.Add(this.label_CoderResult);
            this.groupBox_Coder.Controls.Add(this.label_CoderText);
            this.groupBox_Coder.Controls.Add(this.richTextBox_CoderOut);
            this.groupBox_Coder.Controls.Add(this.richTextBox_CoderIn);
            this.groupBox_Coder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Coder.Location = new System.Drawing.Point(11, 52);
            this.groupBox_Coder.Name = "groupBox_Coder";
            this.groupBox_Coder.Size = new System.Drawing.Size(318, 411);
            this.groupBox_Coder.TabIndex = 1;
            this.groupBox_Coder.TabStop = false;
            this.groupBox_Coder.Text = "Шифратор";
            // 
            // button_CoderOutFile
            // 
            this.button_CoderOutFile.Location = new System.Drawing.Point(9, 374);
            this.button_CoderOutFile.Name = "button_CoderOutFile";
            this.button_CoderOutFile.Size = new System.Drawing.Size(298, 31);
            this.button_CoderOutFile.TabIndex = 6;
            this.button_CoderOutFile.Text = "Записать в файл";
            this.button_CoderOutFile.UseVisualStyleBackColor = true;
            this.button_CoderOutFile.Click += new System.EventHandler(this.button_CoderOutFile_Click);
            // 
            // button_CoderGo
            // 
            this.button_CoderGo.Location = new System.Drawing.Point(9, 198);
            this.button_CoderGo.Name = "button_CoderGo";
            this.button_CoderGo.Size = new System.Drawing.Size(303, 31);
            this.button_CoderGo.TabIndex = 6;
            this.button_CoderGo.Text = "Перевести";
            this.button_CoderGo.UseVisualStyleBackColor = true;
            this.button_CoderGo.Click += new System.EventHandler(this.button_CoderGo_Click);
            // 
            // numericUpDown_CoderCount
            // 
            this.numericUpDown_CoderCount.Location = new System.Drawing.Point(154, 167);
            this.numericUpDown_CoderCount.Name = "numericUpDown_CoderCount";
            this.numericUpDown_CoderCount.Size = new System.Drawing.Size(38, 23);
            this.numericUpDown_CoderCount.TabIndex = 3;
            this.numericUpDown_CoderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_CoderCount.ValueChanged += new System.EventHandler(this.numericUpDown_CoderCount_ValueChanged);
            // 
            // button_CoderClear
            // 
            this.button_CoderClear.Location = new System.Drawing.Point(198, 162);
            this.button_CoderClear.Name = "button_CoderClear";
            this.button_CoderClear.Size = new System.Drawing.Size(113, 30);
            this.button_CoderClear.TabIndex = 5;
            this.button_CoderClear.Text = "Сброс";
            this.button_CoderClear.UseVisualStyleBackColor = true;
            this.button_CoderClear.Click += new System.EventHandler(this.button_CoderClear_Click);
            // 
            // button_CoderFile
            // 
            this.button_CoderFile.Location = new System.Drawing.Point(9, 162);
            this.button_CoderFile.Name = "button_CoderFile";
            this.button_CoderFile.Size = new System.Drawing.Size(139, 30);
            this.button_CoderFile.TabIndex = 2;
            this.button_CoderFile.Text = "Из файла";
            this.button_CoderFile.UseVisualStyleBackColor = true;
            this.button_CoderFile.Click += new System.EventHandler(this.button_CoderFile_Click);
            // 
            // label_CoderResult
            // 
            this.label_CoderResult.AutoSize = true;
            this.label_CoderResult.Location = new System.Drawing.Point(121, 234);
            this.label_CoderResult.Name = "label_CoderResult";
            this.label_CoderResult.Size = new System.Drawing.Size(84, 17);
            this.label_CoderResult.TabIndex = 1;
            this.label_CoderResult.Text = "Результат: ";
            // 
            // label_CoderText
            // 
            this.label_CoderText.AutoSize = true;
            this.label_CoderText.Location = new System.Drawing.Point(138, 19);
            this.label_CoderText.Name = "label_CoderText";
            this.label_CoderText.Size = new System.Drawing.Size(54, 17);
            this.label_CoderText.TabIndex = 1;
            this.label_CoderText.Text = "Текст: ";
            // 
            // richTextBox_CoderOut
            // 
            this.richTextBox_CoderOut.Location = new System.Drawing.Point(9, 258);
            this.richTextBox_CoderOut.Name = "richTextBox_CoderOut";
            this.richTextBox_CoderOut.ReadOnly = true;
            this.richTextBox_CoderOut.Size = new System.Drawing.Size(298, 112);
            this.richTextBox_CoderOut.TabIndex = 0;
            this.richTextBox_CoderOut.Text = "";
            // 
            // richTextBox_CoderIn
            // 
            this.richTextBox_CoderIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CoderIn.Location = new System.Drawing.Point(9, 40);
            this.richTextBox_CoderIn.Name = "richTextBox_CoderIn";
            this.richTextBox_CoderIn.Size = new System.Drawing.Size(298, 112);
            this.richTextBox_CoderIn.TabIndex = 0;
            this.richTextBox_CoderIn.Text = "";
            // 
            // groupBox_Decoder
            // 
            this.groupBox_Decoder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Decoder.Controls.Add(this.button_DecoderOutFIle);
            this.groupBox_Decoder.Controls.Add(this.button_DecoderGo);
            this.groupBox_Decoder.Controls.Add(this.numericUpDown1_DecoderCount);
            this.groupBox_Decoder.Controls.Add(this.button_DecoderClean);
            this.groupBox_Decoder.Controls.Add(this.button_DecoderFile);
            this.groupBox_Decoder.Controls.Add(this.label_DecoderResult);
            this.groupBox_Decoder.Controls.Add(this.label_DecoderText);
            this.groupBox_Decoder.Controls.Add(this.richTextBox_DecoderOut);
            this.groupBox_Decoder.Controls.Add(this.richTextBox_DecoderIn);
            this.groupBox_Decoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Decoder.Location = new System.Drawing.Point(342, 52);
            this.groupBox_Decoder.Name = "groupBox_Decoder";
            this.groupBox_Decoder.Size = new System.Drawing.Size(318, 411);
            this.groupBox_Decoder.TabIndex = 2;
            this.groupBox_Decoder.TabStop = false;
            this.groupBox_Decoder.Text = "Дешифратор";
            // 
            // button_DecoderOutFIle
            // 
            this.button_DecoderOutFIle.Location = new System.Drawing.Point(14, 374);
            this.button_DecoderOutFIle.Name = "button_DecoderOutFIle";
            this.button_DecoderOutFIle.Size = new System.Drawing.Size(298, 31);
            this.button_DecoderOutFIle.TabIndex = 6;
            this.button_DecoderOutFIle.Text = "Записать в файл";
            this.button_DecoderOutFIle.UseVisualStyleBackColor = true;
            this.button_DecoderOutFIle.Click += new System.EventHandler(this.button_DecoderOutFIle_Click);
            // 
            // button_DecoderGo
            // 
            this.button_DecoderGo.Location = new System.Drawing.Point(9, 198);
            this.button_DecoderGo.Name = "button_DecoderGo";
            this.button_DecoderGo.Size = new System.Drawing.Size(303, 31);
            this.button_DecoderGo.TabIndex = 6;
            this.button_DecoderGo.Text = "Перевести";
            this.button_DecoderGo.UseVisualStyleBackColor = true;
            this.button_DecoderGo.Click += new System.EventHandler(this.button_DecoderGo_Click);
            // 
            // numericUpDown1_DecoderCount
            // 
            this.numericUpDown1_DecoderCount.Location = new System.Drawing.Point(154, 167);
            this.numericUpDown1_DecoderCount.Name = "numericUpDown1_DecoderCount";
            this.numericUpDown1_DecoderCount.Size = new System.Drawing.Size(38, 23);
            this.numericUpDown1_DecoderCount.TabIndex = 3;
            this.numericUpDown1_DecoderCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button_DecoderClean
            // 
            this.button_DecoderClean.Location = new System.Drawing.Point(198, 162);
            this.button_DecoderClean.Name = "button_DecoderClean";
            this.button_DecoderClean.Size = new System.Drawing.Size(113, 30);
            this.button_DecoderClean.TabIndex = 5;
            this.button_DecoderClean.Text = "Сброс";
            this.button_DecoderClean.UseVisualStyleBackColor = true;
            this.button_DecoderClean.Click += new System.EventHandler(this.button_DecoderClean_Click);
            // 
            // button_DecoderFile
            // 
            this.button_DecoderFile.Location = new System.Drawing.Point(9, 162);
            this.button_DecoderFile.Name = "button_DecoderFile";
            this.button_DecoderFile.Size = new System.Drawing.Size(139, 30);
            this.button_DecoderFile.TabIndex = 2;
            this.button_DecoderFile.Text = "Из файла";
            this.button_DecoderFile.UseVisualStyleBackColor = true;
            this.button_DecoderFile.Click += new System.EventHandler(this.button_DecoderFile_Click);
            // 
            // label_DecoderResult
            // 
            this.label_DecoderResult.AutoSize = true;
            this.label_DecoderResult.Location = new System.Drawing.Point(121, 234);
            this.label_DecoderResult.Name = "label_DecoderResult";
            this.label_DecoderResult.Size = new System.Drawing.Size(84, 17);
            this.label_DecoderResult.TabIndex = 1;
            this.label_DecoderResult.Text = "Результат: ";
            // 
            // label_DecoderText
            // 
            this.label_DecoderText.AutoSize = true;
            this.label_DecoderText.Location = new System.Drawing.Point(138, 19);
            this.label_DecoderText.Name = "label_DecoderText";
            this.label_DecoderText.Size = new System.Drawing.Size(54, 17);
            this.label_DecoderText.TabIndex = 1;
            this.label_DecoderText.Text = "Текст: ";
            // 
            // richTextBox_DecoderOut
            // 
            this.richTextBox_DecoderOut.Location = new System.Drawing.Point(13, 258);
            this.richTextBox_DecoderOut.Name = "richTextBox_DecoderOut";
            this.richTextBox_DecoderOut.ReadOnly = true;
            this.richTextBox_DecoderOut.Size = new System.Drawing.Size(298, 112);
            this.richTextBox_DecoderOut.TabIndex = 0;
            this.richTextBox_DecoderOut.Text = "";
            // 
            // richTextBox_DecoderIn
            // 
            this.richTextBox_DecoderIn.Location = new System.Drawing.Point(9, 40);
            this.richTextBox_DecoderIn.Name = "richTextBox_DecoderIn";
            this.richTextBox_DecoderIn.Size = new System.Drawing.Size(298, 112);
            this.richTextBox_DecoderIn.TabIndex = 0;
            this.richTextBox_DecoderIn.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.groupBox_Decoder);
            this.Controls.Add(this.groupBox_Coder);
            this.Controls.Add(this.comboBox_Language);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр Цезаря";
            this.groupBox_Coder.ResumeLayout(false);
            this.groupBox_Coder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CoderCount)).EndInit();
            this.groupBox_Decoder.ResumeLayout(false);
            this.groupBox_Decoder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_DecoderCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.GroupBox groupBox_Coder;
        private System.Windows.Forms.GroupBox groupBox_Decoder;
        private System.Windows.Forms.RichTextBox richTextBox_CoderIn;
        private System.Windows.Forms.RichTextBox richTextBox_DecoderIn;
        private System.Windows.Forms.Label label_CoderText;
        private System.Windows.Forms.Label label_DecoderText;
        private System.Windows.Forms.Button button_CoderFile;
        private System.Windows.Forms.Button button_DecoderFile;
        private System.Windows.Forms.Button button_CoderClear;
        private System.Windows.Forms.Button button_DecoderClean;
        private System.Windows.Forms.RichTextBox richTextBox_CoderOut;
        private System.Windows.Forms.RichTextBox richTextBox_DecoderOut;
        private System.Windows.Forms.Label label_CoderResult;
        private System.Windows.Forms.Label label_DecoderResult;
        private System.Windows.Forms.NumericUpDown numericUpDown_CoderCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1_DecoderCount;
        private System.Windows.Forms.Button button_CoderGo;
        private System.Windows.Forms.Button button_DecoderGo;
        private System.Windows.Forms.Button button_CoderOutFile;
        private System.Windows.Forms.Button button_DecoderOutFIle;
    }
}

