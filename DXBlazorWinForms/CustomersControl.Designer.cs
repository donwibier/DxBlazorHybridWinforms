namespace DXBlazorWinForms
{
    partial class CustomersControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colcustomer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            collast_name = new DevExpress.XtraGrid.Columns.GridColumn();
            colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            colage = new DevExpress.XtraGrid.Columns.GridColumn();
            colgender = new DevExpress.XtraGrid.Columns.GridColumn();
            coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            colcity = new DevExpress.XtraGrid.Columns.GridColumn();
            colcountry = new DevExpress.XtraGrid.Columns.GridColumn();
            colphone_number = new DevExpress.XtraGrid.Columns.GridColumn();
            colavatar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            gridControl1.Location = new System.Drawing.Point(449, 421);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(6);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(733, 385);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colcustomer_id, colfirst_name, collast_name, colemail, colage, colgender, coladdress, colcity, colcountry, colphone_number, colavatar });
            gridView1.DetailHeight = 673;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsEditForm.PopupEditFormWidth = 1467;
            gridView1.RowClick += gridView1_RowClick;
            gridView1.RowCellClick += gridView1_RowCellClick;
            gridView1.RowUpdated += gridView1_RowUpdated;
            // 
            // colcustomer_id
            // 
            colcustomer_id.Caption = "ID";
            colcustomer_id.FieldName = "customer_id";
            colcustomer_id.MinWidth = 37;
            colcustomer_id.Name = "colcustomer_id";
            colcustomer_id.Width = 137;
            // 
            // colfirst_name
            // 
            colfirst_name.Caption = "Firstname";
            colfirst_name.FieldName = "first_name";
            colfirst_name.MinWidth = 37;
            colfirst_name.Name = "colfirst_name";
            colfirst_name.Visible = true;
            colfirst_name.VisibleIndex = 0;
            colfirst_name.Width = 137;
            // 
            // collast_name
            // 
            collast_name.Caption = "Lastname";
            collast_name.FieldName = "last_name";
            collast_name.MinWidth = 37;
            collast_name.Name = "collast_name";
            collast_name.Visible = true;
            collast_name.VisibleIndex = 1;
            collast_name.Width = 137;
            // 
            // colemail
            // 
            colemail.Caption = "Email";
            colemail.FieldName = "email";
            colemail.MinWidth = 37;
            colemail.Name = "colemail";
            colemail.Visible = true;
            colemail.VisibleIndex = 2;
            colemail.Width = 137;
            // 
            // colage
            // 
            colage.Caption = "Age";
            colage.FieldName = "age";
            colage.MinWidth = 37;
            colage.Name = "colage";
            colage.Width = 137;
            // 
            // colgender
            // 
            colgender.Caption = "Gender";
            colgender.FieldName = "gender";
            colgender.MinWidth = 37;
            colgender.Name = "colgender";
            colgender.Width = 137;
            // 
            // coladdress
            // 
            coladdress.Caption = "Address";
            coladdress.FieldName = "address";
            coladdress.MinWidth = 37;
            coladdress.Name = "coladdress";
            coladdress.Width = 137;
            // 
            // colcity
            // 
            colcity.Caption = "City";
            colcity.FieldName = "city";
            colcity.MinWidth = 37;
            colcity.Name = "colcity";
            colcity.Width = 137;
            // 
            // colcountry
            // 
            colcountry.Caption = "Country";
            colcountry.FieldName = "country";
            colcountry.MinWidth = 37;
            colcountry.Name = "colcountry";
            colcountry.Visible = true;
            colcountry.VisibleIndex = 3;
            colcountry.Width = 137;
            // 
            // colphone_number
            // 
            colphone_number.Caption = "Phone";
            colphone_number.FieldName = "phone_number";
            colphone_number.MinWidth = 37;
            colphone_number.Name = "colphone_number";
            colphone_number.Visible = true;
            colphone_number.VisibleIndex = 4;
            colphone_number.Width = 137;
            // 
            // colavatar
            // 
            colavatar.Caption = "Avatar";
            colavatar.FieldName = "avatar";
            colavatar.MinWidth = 37;
            colavatar.Name = "colavatar";
            colavatar.Width = 137;
            // 
            // CustomersControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "CustomersControl";
            Size = new System.Drawing.Size(1226, 883);
            Load += CustomersControl_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcustomer_id;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn collast_name;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colage;
        private DevExpress.XtraGrid.Columns.GridColumn colgender;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colcity;
        private DevExpress.XtraGrid.Columns.GridColumn colcountry;
        private DevExpress.XtraGrid.Columns.GridColumn colphone_number;
        private DevExpress.XtraGrid.Columns.GridColumn colavatar;
    }
}
