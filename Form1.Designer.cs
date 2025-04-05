namespace Win_Form_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            textBox1 = new TextBox();
            Assay = new ListBox();
            button1 = new Button();
            button2 = new Button();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            Result = new TextBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(53, 100);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(53, 130);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(53, 160);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(297, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 20);
            textBox1.TabIndex = 3;
            textBox1.Text = "QC checklist";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Assay
            // 
            Assay.BorderStyle = BorderStyle.FixedSingle;
            Assay.FormattingEnabled = true;
            Assay.Location = new Point(53, 56);
            Assay.Name = "Assay";
            Assay.Size = new Size(150, 22);
            Assay.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(297, 212);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Approve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 212);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Reject";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(53, 190);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(53, 220);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(101, 24);
            checkBox5.TabIndex = 8;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            Result.Location = new Point(297, 100);
            Result.Name = "Result";
            Result.Size = new Size(196, 27);
            Result.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 331);
            Controls.Add(Result);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Assay);
            Controls.Add(textBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox textBox1;
        private ListBox Assay;
        private Button button1;
        private Button button2;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private TextBox Result;
    }
}
