namespace OldCodes
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox_In = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_MonoPoliby = new System.Windows.Forms.RadioButton();
            this.radioButton_Mono = new System.Windows.Forms.RadioButton();
            this.radioButton_Code = new System.Windows.Forms.RadioButton();
            this.radioButton_Decode = new System.Windows.Forms.RadioButton();
            this.richTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(79, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Show Poliby Square";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox_In
            // 
            this.richTextBox_In.AutoWordSelection = true;
            this.richTextBox_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_In.Location = new System.Drawing.Point(28, 100);
            this.richTextBox_In.Name = "richTextBox_In";
            this.richTextBox_In.Size = new System.Drawing.Size(306, 96);
            this.richTextBox_In.TabIndex = 3;
            this.richTextBox_In.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_MonoPoliby);
            this.groupBox1.Controls.Add(this.radioButton_Mono);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(28, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // radioButton_MonoPoliby
            // 
            this.radioButton_MonoPoliby.AutoSize = true;
            this.radioButton_MonoPoliby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_MonoPoliby.Location = new System.Drawing.Point(146, 24);
            this.radioButton_MonoPoliby.Name = "radioButton_MonoPoliby";
            this.radioButton_MonoPoliby.Size = new System.Drawing.Size(152, 21);
            this.radioButton_MonoPoliby.TabIndex = 1;
            this.radioButton_MonoPoliby.Text = "Mono+Poliby Cipher";
            this.radioButton_MonoPoliby.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mono
            // 
            this.radioButton_Mono.AutoSize = true;
            this.radioButton_Mono.Checked = true;
            this.radioButton_Mono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Mono.Location = new System.Drawing.Point(14, 25);
            this.radioButton_Mono.Name = "radioButton_Mono";
            this.radioButton_Mono.Size = new System.Drawing.Size(102, 21);
            this.radioButton_Mono.TabIndex = 0;
            this.radioButton_Mono.TabStop = true;
            this.radioButton_Mono.Text = "MonoCipher";
            this.radioButton_Mono.UseVisualStyleBackColor = true;
            // 
            // radioButton_Code
            // 
            this.radioButton_Code.AutoSize = true;
            this.radioButton_Code.Checked = true;
            this.radioButton_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Code.Location = new System.Drawing.Point(63, 206);
            this.radioButton_Code.Name = "radioButton_Code";
            this.radioButton_Code.Size = new System.Drawing.Size(70, 21);
            this.radioButton_Code.TabIndex = 4;
            this.radioButton_Code.TabStop = true;
            this.radioButton_Code.Text = "Coding";
            this.radioButton_Code.UseVisualStyleBackColor = true;
            // 
            // radioButton_Decode
            // 
            this.radioButton_Decode.AutoSize = true;
            this.radioButton_Decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Decode.Location = new System.Drawing.Point(194, 206);
            this.radioButton_Decode.Name = "radioButton_Decode";
            this.radioButton_Decode.Size = new System.Drawing.Size(86, 21);
            this.radioButton_Decode.TabIndex = 5;
            this.radioButton_Decode.Text = "Decoding";
            this.radioButton_Decode.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Out
            // 
            this.richTextBox_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Out.Location = new System.Drawing.Point(28, 316);
            this.richTextBox_Out.Name = "richTextBox_Out";
            this.richTextBox_Out.ReadOnly = true;
            this.richTextBox_Out.Size = new System.Drawing.Size(306, 96);
            this.richTextBox_Out.TabIndex = 6;
            this.richTextBox_Out.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output: ";
            // 
            // button_Read
            // 
            this.button_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Read.Location = new System.Drawing.Point(12, 44);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(162, 33);
            this.button_Read.TabIndex = 1;
            this.button_Read.Text = "Read from file";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(181, 44);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(161, 33);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 477);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.radioButton_Decode);
            this.Controls.Add(this.radioButton_Code);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Out);
            this.Controls.Add(this.richTextBox_In);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ancient Ciphers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox_In;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Mono;
        private System.Windows.Forms.RadioButton radioButton_Code;
        private System.Windows.Forms.RadioButton radioButton_Decode;
        private System.Windows.Forms.RadioButton radioButton_MonoPoliby;
        private System.Windows.Forms.RichTextBox richTextBox_Out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Clear;
    }
}

