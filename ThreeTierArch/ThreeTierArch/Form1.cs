using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeTierArch.BLL;
using ThreeTierArch.DAL;

namespace ThreeTierArch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                EmplyeeBal p = new EmplyeeBal();
                this.dataGridView1.DataSource = p.GetEmployees();
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16 id = Convert.ToInt16(textBox1.Text);
            try
            {
                EmplyeeBal p = new EmplyeeBal();
                this.dataGridView1.DataSource = p.GetEmployees(id);
            }
            catch
            {
                MessageBox.Show("Error Occurred");
            }
        }
    }
}
