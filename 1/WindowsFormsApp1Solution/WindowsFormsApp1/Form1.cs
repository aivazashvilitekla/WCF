using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client sv = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = Convert.ToInt32(numericUpDown1.Value);
                
                ServiceReference1.Customers r = sv.GetCustomer(custId);
                if (r!=null)
                {
                    
                    MessageBox.Show($"Fullname of Customer with an id of {custId} - {r.Fname} {r.Lname}.");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ls = sv.GetAllCustomers();
                dataGridView1.DataSource = ls;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.CurrentRow;
                int Id = (int)row.Cells["Id"].Value;
                sv.DeleteCustomer(Id);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
