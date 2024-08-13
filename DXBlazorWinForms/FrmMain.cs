using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.DataContracts;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXBlazorWinForms
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private BlazorWebView webView;
        private CustomerStore customerStore;
        private CustomersControl customersControl;
        readonly IServiceProvider serviceProvider;
        readonly AppBridge appBridge;
        public FrmMain(IServiceProvider serviceProvider, CustomerStore customerStore,
            AppBridge appBridge
            )
        {
            this.appBridge = appBridge;
            this.appBridge.MainForm = this;
            this.serviceProvider = serviceProvider;
            InitializeComponent();


            this.customerStore = customerStore;
            this.customerStore.CustomersChanged += CustomerStore_CustomersChanged;

            this.customersControl = new CustomersControl(this.customerStore);
            fluentDesignFormContainer1.Controls.Add(customersControl);
            customersControl.Dock = DockStyle.Fill;

            LoadBlazor<Blazor.Routes>();
        }



        protected void LoadBlazor<T>()
           where T : Microsoft.AspNetCore.Components.IComponent
        {
            if (webView != null)
            {
                webView.Dispose();
            }

            webView = new BlazorWebView();
            fluentDesignFormContainer1.Controls.Add(webView);
            webView.Services = this.serviceProvider;
            webView.Dock = DockStyle.Fill;
            webView.HostPage = "wwwroot\\index.html";
            webView.RootComponents.Add<T>("#app");

        }


        public void ShowGridControl()
        {
            if (customersControl != null)
                customersControl.Visible = true;
            if (webView != null)
                webView.Visible = false;
        }

        public void ShowWebView()
        {
            if (customersControl != null)
                customersControl.Visible = false;
            if (webView != null)
                webView.Visible = true;
        }
        
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            ShowGridControl();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            ShowWebView();
            if (appBridge.BlazorLayout != null)
                appBridge.BlazorLayout.Navigate("/counter");
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            ShowWebView();
            if (appBridge.BlazorLayout != null)
                appBridge.BlazorLayout.Navigate("/");
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {            
            
        }

        void CustomerStore_CustomersChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            alertControl1.Show(this, "Customer", $"A customer has been {e.Action}", true);
        }
        public void ShowCustomerDetail(int customer_Id, string sender = "blazor")
        {
            ShowWebView();
            //.abnc            
        }

        public void ShowCustomerEditForm(int customer_Id)
        {
            Customer item = customerStore.Customers.First(c => c.customer_id == customer_Id);
            if (item != null)
            {
                DlgEditCustomer dlg = new DlgEditCustomer(customerStore);
                dlg.SetCustomer(item);
                dlg.ShowDialog();
            }
        }
    }
}
