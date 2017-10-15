namespace Cipher
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
            this.button_Go = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Input = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Code = new System.Windows.Forms.RadioButton();
            this.radioButton_Decode = new System.Windows.Forms.RadioButton();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Go
            // 
            this.button_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Go.Location = new System.Drawing.Point(107, 345);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(75, 34);
            this.button_Go.TabIndex = 6;
            this.button_Go.Text = "Go!";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(149, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show ADFGVX Cipher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 47);
            this.button3.TabIndex = 0;
            this.button3.Text = "Show 4 Squares";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input:";
            // 
            // richTextBox_Input
            // 
            this.richTextBox_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Input.Location = new System.Drawing.Point(12, 90);
            this.richTextBox_Input.Name = "richTextBox_Input";
            this.richTextBox_Input.Size = new System.Drawing.Size(258, 96);
            this.richTextBox_Input.TabIndex = 2;
            this.richTextBox_Input.Text = "";
            // 
            // richTextBox_Output
            // 
            this.richTextBox_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_Output.Location = new System.Drawing.Point(12, 242);
            this.richTextBox_Output.Name = "richTextBox_Output";
            this.richTextBox_Output.ReadOnly = true;
            this.richTextBox_Output.Size = new System.Drawing.Size(258, 96);
            this.richTextBox_Output.TabIndex = 5;
            this.richTextBox_Output.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            // 
            // radioButton_Code
            // 
            this.radioButton_Code.AutoSize = true;
            this.radioButton_Code.Checked = true;
            this.radioButton_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Code.Location = new System.Drawing.Point(39, 196);
            this.radioButton_Code.Name = "radioButton_Code";
            this.radioButton_Code.Size = new System.Drawing.Size(59, 21);
            this.radioButton_Code.TabIndex = 3;
            this.radioButton_Code.TabStop = true;
            this.radioButton_Code.Text = "Code";
            this.radioButton_Code.UseVisualStyleBackColor = true;
            // 
            // radioButton_Decode
            // 
            this.radioButton_Decode.AutoSize = true;
            this.radioButton_Decode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_Decode.Location = new System.Drawing.Point(104, 196);
            this.radioButton_Decode.Name = "radioButton_Decode";
            this.radioButton_Decode.Size = new System.Drawing.Size(75, 21);
            this.radioButton_Decode.TabIndex = 4;
            this.radioButton_Decode.Text = "Decode";
            this.radioButton_Decode.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clear.Location = new System.Drawing.Point(196, 192);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 30);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 386);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.radioButton_Decode);
            this.Controls.Add(this.radioButton_Code);
            this.Controls.Add(this.richTextBox_Output);
            this.Controls.Add(this.richTextBox_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4 Squares and ADFGVX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Input;
        private System.Windows.Forms.RichTextBox richTextBox_Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Code;
        private System.Windows.Forms.RadioButton radioButton_Decode;
        private System.Windows.Forms.Button button_Clear;
    }
}

