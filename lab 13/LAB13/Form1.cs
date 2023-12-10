using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB13
{
    public partial class Form1 : Form
    {
        int index = 0; // variable for the index in all arrays
        int[] sum = { 2, 1, 1, 1, 2 }; // array with correct answers
        string[] s = { " The capital of North Korea ", " The capital of Ireland ", " The capital of Cyprus ", " The capital of Australia ", " The capital of Canada " };
        string[,] value =
        {// array with answers to the question
            {"Dhaka", "Pyongyang", "Jakarta", "Seoul"},
            {"Dublin", "Kingston", " Vienna", "Ottawa"},
            {" Nicosia "," Tallinn "," Tehran "," Sidney "},
            {" Sidney "," Canberra "," cc "," cc "},
            { "Oslo "," Ottawa "," cc "," cc "}
};

        int temp = 0; // variable
        int result = 0; // amount of typed data

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(index);
        }

        void LoadData(int i) // the function loads data from arrays by index
        {
            if (index >= s.Length) return; // check for going beyond the index
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index >= s.Length) return;
            if (radioButton1.Checked == true)
                temp = 1;
            if (radioButton2.Checked == true)
                temp = 2;
            if (radioButton3.Checked == true)
                temp = 3;
            if (radioButton4.Checked == true)
                temp = 4;
            if (sum[index] == temp)
                result += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            LoadData(index);
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = "Вы выбрали " + result.ToString() + "баллов";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
