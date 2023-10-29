namespace lab8_2
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
            groupBox1 = new GroupBox();
            groupbutton1 = new Button();
            groupradioButton2 = new RadioButton();
            groupradioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            genderradioB1 = new RadioButton();
            genderradioB2 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupbutton1);
            groupBox1.Controls.Add(groupradioButton2);
            groupBox1.Controls.Add(groupradioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(521, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 392);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "questionarie";
            // 
            // groupbutton1
            // 
            groupbutton1.Location = new Point(81, 303);
            groupbutton1.Name = "groupbutton1";
            groupbutton1.Size = new Size(94, 29);
            groupbutton1.TabIndex = 2;
            groupbutton1.Text = "Submit";
            groupbutton1.UseVisualStyleBackColor = true;
            groupbutton1.Click += groupbutton1_Click;
            // 
            // groupradioButton2
            // 
            groupradioButton2.AutoSize = true;
            groupradioButton2.Location = new Point(47, 213);
            groupradioButton2.Name = "groupradioButton2";
            groupradioButton2.Size = new Size(50, 24);
            groupradioButton2.TabIndex = 1;
            groupradioButton2.Text = "No";
            groupradioButton2.UseVisualStyleBackColor = true;
            // 
            // groupradioButton1
            // 
            groupradioButton1.AutoSize = true;
            groupradioButton1.Location = new Point(47, 174);
            groupradioButton1.Name = "groupradioButton1";
            groupradioButton1.Size = new Size(51, 24);
            groupradioButton1.TabIndex = 1;
            groupradioButton1.Text = "Yes";
            groupradioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 117);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Do you like it?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 74);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(152, 243);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "COM";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(322, 243);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "ELEC";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(141, 316);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(49, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "C#";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(234, 243);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "MAT";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(218, 316);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(77, 24);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "Physics";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(313, 316);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(85, 24);
            checkBox6.TabIndex = 3;
            checkBox6.Text = "Calculus";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // genderradioB1
            // 
            genderradioB1.AutoSize = true;
            genderradioB1.Location = new Point(138, 174);
            genderradioB1.Name = "genderradioB1";
            genderradioB1.Size = new Size(78, 24);
            genderradioB1.TabIndex = 4;
            genderradioB1.TabStop = true;
            genderradioB1.Text = "Female";
            genderradioB1.UseVisualStyleBackColor = true;
            // 
            // genderradioB2
            // 
            genderradioB2.AutoSize = true;
            genderradioB2.Location = new Point(234, 175);
            genderradioB2.Name = "genderradioB2";
            genderradioB2.Size = new Size(63, 24);
            genderradioB2.TabIndex = 4;
            genderradioB2.TabStop = true;
            genderradioB2.Text = "Male";
            genderradioB2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 175);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 242);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 5;
            label4.Text = "Department:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 315);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 5;
            label5.Text = "Course:";
            // 
            // button1
            // 
            button1.Location = new Point(231, 386);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(genderradioB1);
            Controls.Add(genderradioB2);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button groupbutton1;
        private RadioButton groupradioButton2;
        private RadioButton groupradioButton1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox2;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private RadioButton genderradioB1;
        private RadioButton genderradioB2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}