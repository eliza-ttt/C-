namespace lab8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.groupradioButton1.Checked)
                this.groupradioButton1.Checked = false;
            if (this.groupradioButton2.Checked)
                this.groupradioButton2.Checked = false;
        }

        private void groupbutton1_Click(object sender, EventArgs e)
        {
            if (this.groupradioButton1.Checked)
                MessageBox.Show("You like it! Thanks!");
            else if (this.groupradioButton2.Checked)
                MessageBox.Show("You do not like it! We will work on it!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender;
            if (genderradioB1.Checked == true)
            {
                gender = "Female";
            }
            else gender = "Male";

            string department;
            if (checkBox1.Checked == true)
            {
                department = "COM";
            }
            else if (checkBox2.Checked == true)
            {
                department = "MAT";
            }
            else department = "ELEC";

            string course;
            if (checkBox4.Checked == true)
            {
                course = "C#";
            }
            else if (checkBox5.Checked == true)
            {
                course = "Physics";
            }
            else course = "Calculus";

            MessageBox.Show("Name :   " + textBox1.Text + "\n" + "Gender :   "+ gender + "\n" + "Department :   " + department + "\n" + "Course :   " + course);
        }
    }
}