using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClass;

namespace Lab2._6_BiblWorm_
{
    public partial class Form1 : Form
    {
        List<Item> its = new List<Item>();
        public string Author
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Title
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

        public bool Existence
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }

        public bool SortInvNumber
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }

        public bool ReturnTime
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }

        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        // Magazine 

        public string MagTitle
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public string MagVolume
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public int MagNumber
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }

        public int MagYear
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public int MagInvNumber
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }

        public bool MagExistence
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existence);
            if (ReturnTime)
            {
                b.ReturnSrok();
                b.PriceBook(PeriodUse);
                its.Add(b);
            }
            else
            {
                b.PriceBook(PeriodUse);
                its.Add(b);
            }
            Author = Title = PublishHouse = "";
            Page = 1;
            InvNumber = 1;
            PeriodUse = 1;
            Year = 2020;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                its.Sort();
                StringBuilder sb = new StringBuilder();
                foreach (Item item in its)
                {
                    sb.Append("\n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine mag = new Magazine(MagVolume, MagNumber, MagTitle, MagYear, MagInvNumber, MagExistence);
            for (int i = 0; i < its.Count; i++)
            {
                
            }
            its.Add(mag);
            MagVolume = MagTitle = "";
            MagYear = 2020;
            MagInvNumber = 0;
            MagExistence = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}