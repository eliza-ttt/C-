namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text) || string.IsNullOrEmpty(txtGender.Text))
                return;
            ListViewItem item = new ListViewItem(txtFname.Text);
            item.SubItems.Add(txtLname.Text);
            item.SubItems.Add(txtGender.Text);
            listView.Items.Add(item);
            txtLname.Clear();
            txtFname.Clear();
            txtGender.Clear();
            txtFname.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.Items[0]);
        }
    }
}