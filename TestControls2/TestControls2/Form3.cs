using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControls2
{
    public partial class Form3 : Form
    {
        public Form3()

        {
            InitializeComponent();
        }

        public DataTable data()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Rows.Add("Madhu", 25);
            dt.Rows.Add("Mad", 20);
            dt.Rows.Add("Chinni", 24);
            dt.Rows.Add("krishna", 19);
            dt.Rows.Add("Keerthi", 13);
            dt.Rows.Add("Madhavi", 23);

            return dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable d;
            d = data();

            comboBox1.DataSource = d;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Age";
            
        }

        public List<List<String>> names1()
        {
            //first method
            List<List<String>> l = new List<List<String>>()
            {
                new List<string>{ "Madhu", "Madhavi", "Keerthi" },
                new List<string>{ "a", "bh", "hbdjf", "jsdfbdj" },
                new List<string>{ "a" },
            };

            //second method
            List<String> l1 = new List<String>() { "Madhu", "Madhavi", "Keerthi" };
            List<String> l2 = new List<String>() { "Madhu", "Madhavi", "Keerthi" };
            List<String> l3 = new List<String>() { "Madhu", "Madhavi", "Keerthi" };
            List<String> l4 = new List<String>() { "Madhu", "Madhavi", "Keerthi" };

            l.Add(l1);
            l.Add(l2);
            l.Add(l3);
            l.Add(l4);
            return l;
        }

        List<List<String>> li =  names1();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //public List<String> names(string i, string j, string k)
        //{
        //    List<String> list1 = new List<String>();
        //    list1.Add(i);
        //    list1.Add(j);
        //    list1.Add(k);
        //    return list1;
        //}

        //List<String> l =  names("Madhu", "Mitha", "Marthla");
    }
}
