namespace FeistelCipher
{
    partial class MainForm
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
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Propose = new System.Windows.Forms.Button();
            this.numericUpDown_BlockSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_K10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_K20 = new System.Windows.Forms.TextBox();
            this.groupBox_Mode = new System.Windows.Forms.GroupBox();
            this.radioButton_Decoder = new System.Windows.Forms.RadioButton();
            this.radioButton_Coder = new System.Windows.Forms.RadioButton();
            this.groupBox_ChangeKey = new System.Windows.Forms.GroupBox();
            this.radioButton_Type3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Type1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Reverse = new System.Windows.Forms.RadioButton();
            this.button_Go = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BlockSize)).BeginInit();
            this.groupBox_Mode.SuspendLayout();
            this.groupBox_ChangeKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.Location = new System.Drawing.Point(12, 59);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(260, 99);
            this.richTextBox_Input.TabIndex = 0;
            this.richTextBox_Input.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "InputText:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BlockSize:";
            // 
            // button_Propose
            // 
            this.button_Propose.Location = new System.Drawing.Point(146, 164);
            this.button_Propose.Name = "button_Propose";
            this.button_Propose.Size = new System.Drawing.Size(75, 23);
            this.button_Propose.TabIndex = 2;
            this.button_Propose.Text = "Propose";
            this.button_Propose.UseVisualStyleBackColor = true;
            this.button_Propose.Click += new System.EventHandler(this.button_Propose_Click);
            // 
            // numericUpDown_BlockSize
            // 
            this.numericUpDown_BlockSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_BlockSize.Location = new System.Drawing.Point(99, 166);
            this.numericUpDown_BlockSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_BlockSize.Name = "numericUpDown_BlockSize";
            this.numericUpDown_BlockSize.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_BlockSize.TabIndex = 1;
            this.numericUpDown_BlockSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_BlockSize.ValueChanged += new System.EventHandler(this.numericUpDown_BlockSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key1:";
            // 
            // textBox_K10
            // 
            this.textBox_K10.Location = new System.Drawing.Point(41, 193);
            this.textBox_K10.Name = "textBox_K10";
            this.textBox_K10.Size = new System.Drawing.Size(24, 20);
            this.textBox_K10.TabIndex = 3;
            this.textBox_K10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output text:";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Location = new System.Drawing.Point(15, 300);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.Size = new System.Drawing.Size(248, 96);
            this.richTextBox_Output.TabIndex = 5;
            this.richTextBox_Output.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key2:";
            // 
            // textBox_K20
            // 
            this.textBox_K20.Location = new System.Drawing.Point(41, 260);
            this.textBox_K20.Name = "textBox_K20";
            this.textBox_K20.Size = new System.Drawing.Size(24, 20);
            this.textBox_K20.TabIndex = 4;
            // 
            // groupBox_Mode
            // 
            this.groupBox_Mode.Controls.Add(this.radioButton_Decoder);
            this.groupBox_Mode.Controls.Add(this.radioButton_Coder);
            this.groupBox_Mode.Location = new System.Drawing.Point(12, 6);
            this.groupBox_Mode.Name = "groupBox_Mode";
            this.groupBox_Mode.Size = new System.Drawing.Size(260, 31);
            this.groupBox_Mode.TabIndex = 11;
            this.groupBox_Mode.TabStop = false;
            this.groupBox_Mode.Text = "Mode";
            // 
            // radioButton_Decoder
            // 
            this.radioButton_Decoder.AutoSize = true;
            this.radioButton_Decoder.Location = new System.Drawing.Point(134, 8);
            this.radioButton_Decoder.Name = "radioButton_Decoder";
            this.radioButton_Decoder.Size = new System.Drawing.Size(66, 17);
            this.radioButton_Decoder.TabIndex = 1;
            this.radioButton_Decoder.TabStop = true;
            this.radioButton_Decoder.Text = "Decoder";
            this.radioButton_Decoder.UseVisualStyleBackColor = true;
            // 
            // radioButton_Coder
            // 
            this.radioButton_Coder.AutoSize = true;
            this.radioButton_Coder.Checked = true;
            this.radioButton_Coder.Location = new System.Drawing.Point(75, 8);
            this.radioButton_Coder.Name = "radioButton_Coder";
            this.radioButton_Coder.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Coder.TabIndex = 0;
            this.radioButton_Coder.TabStop = true;
            this.radioButton_Coder.Text = "Coder";
            this.radioButton_Coder.UseVisualStyleBackColor = true;
            // 
            // groupBox_ChangeKey
            // 
            this.groupBox_ChangeKey.Controls.Add(this.radioButton_Type3);
            this.groupBox_ChangeKey.Controls.Add(this.radioButton_Type1);
            this.groupBox_ChangeKey.Controls.Add(this.radioButton_Reverse);
            this.groupBox_ChangeKey.Location = new System.Drawing.Point(8, 216);
            this.groupBox_ChangeKey.Name = "groupBox_ChangeKey";
            this.groupBox_ChangeKey.Size = new System.Drawing.Size(255, 42);
            this.groupBox_ChangeKey.TabIndex = 12;
            this.groupBox_ChangeKey.TabStop = false;
            this.groupBox_ChangeKey.Text = "Mode for change key2";
            // 
            // radioButton_Type3
            // 
            this.radioButton_Type3.AutoSize = true;
            this.radioButton_Type3.Location = new System.Drawing.Point(191, 17);
            this.radioButton_Type3.Name = "radioButton_Type3";
            this.radioButton_Type3.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Type3.TabIndex = 2;
            this.radioButton_Type3.TabStop = true;
            this.radioButton_Type3.Text = "Type2";
            this.radioButton_Type3.UseVisualStyleBackColor = true;
            this.radioButton_Type3.Click += new System.EventHandler(this.radioButton_Type2_Click);
            // 
            // radioButton_Type1
            // 
            this.radioButton_Type1.AutoSize = true;
            this.radioButton_Type1.Location = new System.Drawing.Point(107, 17);
            this.radioButton_Type1.Name = "radioButton_Type1";
            this.radioButton_Type1.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Type1.TabIndex = 1;
            this.radioButton_Type1.TabStop = true;
            this.radioButton_Type1.Text = "Type1";
            this.radioButton_Type1.UseVisualStyleBackColor = true;
            this.radioButton_Type1.CheckedChanged += new System.EventHandler(this.radioButton_Type1_CheckedChanged);
            // 
            // radioButton_Reverse
            // 
            this.radioButton_Reverse.AutoSize = true;
            this.radioButton_Reverse.Location = new System.Drawing.Point(6, 17);
            this.radioButton_Reverse.Name = "radioButton_Reverse";
            this.radioButton_Reverse.Size = new System.Drawing.Size(65, 17);
            this.radioButton_Reverse.TabIndex = 0;
            this.radioButton_Reverse.TabStop = true;
            this.radioButton_Reverse.Text = "Reverse";
            this.radioButton_Reverse.UseVisualStyleBackColor = true;
            this.radioButton_Reverse.Click += new System.EventHandler(this.radioButton_Reverse_Click);
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(87, 402);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(75, 23);
            this.button_Go.TabIndex = 13;
            this.button_Go.Text = "Go!";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 433);
            this.Controls.Add(this.button_Go);
            this.Controls.Add(this.groupBox_ChangeKey);
            this.Controls.Add(this.groupBox_Mode);
            this.Controls.Add(this.textBox_K20);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_K10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_BlockSize);
            this.Controls.Add(this.button_Propose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FeistelCipher";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BlockSize)).EndInit();
            this.groupBox_Mode.ResumeLayout(false);
            this.groupBox_Mode.PerformLayout();
            this.groupBox_ChangeKey.ResumeLayout(false);
            this.groupBox_ChangeKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Propose;
        private System.Windows.Forms.NumericUpDown numericUpDown_BlockSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_K10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_K20;
        private System.Windows.Forms.GroupBox groupBox_Mode;
        private System.Windows.Forms.RadioButton radioButton_Coder;
        private System.Windows.Forms.RadioButton radioButton_Decoder;
        private System.Windows.Forms.GroupBox groupBox_ChangeKey;
        private System.Windows.Forms.RadioButton radioButton_Reverse;
        private System.Windows.Forms.RadioButton radioButton_Type1;
        private System.Windows.Forms.RadioButton radioButton_Type3;
        private System.Windows.Forms.Button button_Go;
    }
}

