using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAddCustomer : Form
    {
        ServiceReference1.Service1Client sv = new ServiceReference1.Service1Client();
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = txtbox_fname.Text;
                string lname = txtbox_lname.Text;
                string city = txtbox_city.Text;
                string country = txtbox_country.Text;
                string phone = txtbox_phone.Text;
                sv.AddCustomer(fname, lname, city, country, phone);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
