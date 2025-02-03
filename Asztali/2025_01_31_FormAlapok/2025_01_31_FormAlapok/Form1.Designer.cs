namespace _2025_01_31_FormAlapok
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
            button1 = new Button();
            Színezés_button = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 61);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Szinezés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Színezés_button
            // 
            Színezés_button.AutoSize = true;
            Színezés_button.Location = new Point(51, 87);
            Színezés_button.Name = "Színezés_button";
            Színezés_button.Size = new Size(38, 15);
            Színezés_button.TabIndex = 1;
            Színezés_button.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(51, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(51, 171);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(220, 61);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(198, 154);
            listBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(51, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(458, 264);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(Színezés_button);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "form alapok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Színezés_button;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
