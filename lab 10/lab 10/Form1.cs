namespace lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = studentBindingSource.Current as Student;
            if (obj != null)
            {
                using (StudentInfo frm = new StudentInfo() { SInfo = obj })
                {
                    frm.ShowDialog();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.Add(new Student() { ID = "1", FullName = "Eliza Tursunbekova", Gender = true, Age = 20 });
            studentBindingSource.Add(new Student() { ID = "2", FullName = "Program Programmer", Gender = true, Age = 22 });
            studentBindingSource.Add(new Student() { ID = "3", FullName = "Ben Tursunbekov", Gender = false, Age = 18 });
            studentBindingSource.Add(new Student() { ID = "4", FullName = "John Smith", Gender = true, Age = 12 });


        }
    }
}