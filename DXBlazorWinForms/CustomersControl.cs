using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXBlazorWinForms
{
    public partial class CustomersControl : DevExpress.XtraEditors.XtraUserControl
    {
        private CustomerStore customerStore;
        public CustomersControl(CustomerStore customerStore)
        {
            InitializeComponent();

            this.customerStore = customerStore;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.DataSource = customerStore.Customers;
        }

        private void CustomersControl_Load(object sender, EventArgs e)
        {            
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var item = e.Row as Customer;
            if (item != null)
            {
                customerStore.Update(item);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var item = gridView1.GetRow(e.RowHandle) as Customer;
                if (item != null)
                {
                    DlgEditCustomer dlg = new DlgEditCustomer(customerStore); 
                    dlg.SetCustomer(item);
                    dlg.ShowDialog();
                    //appBridge.MainForm.ShowCustomerDetail(item.customer_id, "wf");
                    e.Handled = true;
                }
            }

        }
    }
}
