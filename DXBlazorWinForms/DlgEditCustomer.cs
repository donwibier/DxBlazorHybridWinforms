using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXBlazorWinForms
{
    public partial class DlgEditCustomer : DevExpress.XtraEditors.XtraForm
    {
        Customer customer;
        readonly CustomerStore customerStore;
        public Customer Customer { 
            get => customer; 
            set => customer = value; 
        }
        public DlgEditCustomer(CustomerStore customerStore)
        {
            this.customerStore = customerStore;
            InitializeComponent();
        }

        private void DlgEditCustomer_Load(object sender, EventArgs e)
        {
            layoutControl1.Dock = DockStyle.Fill;
        }

        public void SetCustomer(Customer customer)
        {
            Customer = customer;
            txtFirstName.Text = Customer.first_name;
            txtLastName.Text = Customer.last_name;
            txtEmail.Text = Customer.email;
            txtCountry.Text = Customer.country;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Customer.first_name = txtFirstName.Text;
            Customer.last_name = txtLastName.Text;
            Customer.email = txtEmail.Text;
            Customer.country = txtCountry.Text;
            customerStore.Update(Customer);
            this.DialogResult = DialogResult.OK;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {            
            this.DialogResult = DialogResult.Cancel;
        }
    }
}