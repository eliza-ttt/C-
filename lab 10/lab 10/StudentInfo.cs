using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_10
{
    public partial class StudentInfo : Form
    {
        public Student SInfo { get; set; }
        public StudentInfo()
        {
            InitializeComponent();
        }

        public StudentInfo(Student std)
        {
            InitializeComponent();
            this.SInfo = std;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            txtStudentId.Text = SInfo.ID;
            txtFullName.Text = SInfo.FullName;
            txtAge.Text = SInfo.Age.ToString();
            checkBGender.Checked = SInfo.Gender;
            if (checkBGender.Checked == true)
                checkBGender.Text = "Male";
            else if (checkBGender.Checked == false)
                checkBGender.Text = "Female";
        }
    }
}
