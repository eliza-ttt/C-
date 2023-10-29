namespace lab_10
{
    partial class StudentInfo
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
            label1 = new Label();
            txtAge = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentId = new TextBox();
            checkBGender = new CheckBox();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(158, 202);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(305, 27);
            txtAge.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 150);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 0;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 202);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 0;
            label4.Text = "Age";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(158, 47);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(305, 27);
            txtStudentId.TabIndex = 1;
            // 
            // checkBGender
            // 
            checkBGender.AutoSize = true;
            checkBGender.Location = new Point(158, 150);
            checkBGender.Name = "checkBGender";
            checkBGender.Size = new Size(18, 17);
            checkBGender.TabIndex = 2;
            checkBGender.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(158, 98);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(305, 27);
            txtFullName.TabIndex = 1;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 260);
            Controls.Add(checkBGender);
            Controls.Add(txtStudentId);
            Controls.Add(txtFullName);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentInfo";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Information";
            Load += StudentInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAge;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentId;
        private CheckBox checkBGender;
        private TextBox txtFullName;
    }
}