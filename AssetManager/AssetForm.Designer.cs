namespace AssetManager
{
    partial class AssetForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetForm));
            this.panel = new System.Windows.Forms.Panel();
            this.btnFront = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.assetTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new AssetManager.appData();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.lblFront = new System.Windows.Forms.Label();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.blbModel = new System.Windows.Forms.Label();
            this.lblTy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblCba = new System.Windows.Forms.Label();
            this.lblWeblink = new System.Windows.Forms.LinkLabel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.btnFront);
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.txtBatch);
            this.panel.Controls.Add(this.lblBatch);
            this.panel.Controls.Add(this.lblDetails);
            this.panel.Controls.Add(this.lblBack);
            this.panel.Controls.Add(this.pbBack);
            this.panel.Controls.Add(this.pbFront);
            this.panel.Controls.Add(this.lblFront);
            this.panel.Controls.Add(this.txtDate);
            this.panel.Controls.Add(this.txtVendor);
            this.panel.Controls.Add(this.txtModel);
            this.panel.Controls.Add(this.txtType);
            this.panel.Controls.Add(this.txtName);
            this.panel.Controls.Add(this.txtID);
            this.panel.Controls.Add(this.lblVendor);
            this.panel.Controls.Add(this.lblDate);
            this.panel.Controls.Add(this.blbModel);
            this.panel.Controls.Add(this.lblTy);
            this.panel.Controls.Add(this.lblName);
            this.panel.Controls.Add(this.lblItem);
            this.panel.Location = new System.Drawing.Point(4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(995, 274);
            this.panel.TabIndex = 0;
            // 
            // btnFront
            // 
            this.btnFront.Location = new System.Drawing.Point(425, 242);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(75, 23);
            this.btnFront.TabIndex = 7;
            this.btnFront.Text = "Browse";
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(741, 242);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Browse";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "batchCode", true));
            this.txtBatch.Location = new System.Drawing.Point(91, 197);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(171, 21);
            this.txtBatch.TabIndex = 5;
            // 
            // assetTableBindingSource
            // 
            this.assetTableBindingSource.DataMember = "AssetTable";
            this.assetTableBindingSource.DataSource = this.appDataBindingSource;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // appData
            // 
            this.appData.DataSetName = "appData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(26, 200);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(61, 13);
            this.lblBatch.TabIndex = 19;
            this.lblBatch.Text = "Bath Code:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(24, 17);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(86, 16);
            this.lblDetails.TabIndex = 16;
            this.lblDetails.Text = "Item Details";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Location = new System.Drawing.Point(738, 17);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(62, 13);
            this.lblBack.TabIndex = 15;
            this.lblBack.Text = "Back Image";
            // 
            // pbBack
            // 
            this.pbBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBack.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.assetTableBindingSource, "backImg", true));
            this.pbBack.Location = new System.Drawing.Point(647, 38);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(256, 198);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 14;
            this.pbBack.TabStop = false;
            // 
            // pbFront
            // 
            this.pbFront.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFront.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.assetTableBindingSource, "frontImg", true));
            this.pbFront.Location = new System.Drawing.Point(333, 38);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(256, 198);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFront.TabIndex = 13;
            this.pbFront.TabStop = false;
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Location = new System.Drawing.Point(422, 17);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(66, 13);
            this.lblFront.TabIndex = 12;
            this.lblFront.Text = "Front Image";
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetTableBindingSource, "itemDate", true));
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(91, 229);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(171, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtVendor
            // 
            this.txtVendor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "Vendor", true));
            this.txtVendor.Location = new System.Drawing.Point(91, 166);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(171, 21);
            this.txtVendor.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "ModelNumber", true));
            this.txtModel.Location = new System.Drawing.Point(91, 135);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(171, 21);
            this.txtModel.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "itemType", true));
            this.txtType.Location = new System.Drawing.Point(91, 104);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(171, 21);
            this.txtType.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "itemName", true));
            this.txtName.Location = new System.Drawing.Point(92, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetTableBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(92, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 21);
            this.txtID.TabIndex = 0;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(41, 169);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(48, 13);
            this.lblVendor.TabIndex = 5;
            this.lblVendor.Text = "Vendor: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(5, 232);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Purchase Date: ";
            // 
            // blbModel
            // 
            this.blbModel.AutoSize = true;
            this.blbModel.Location = new System.Drawing.Point(47, 138);
            this.blbModel.Name = "blbModel";
            this.blbModel.Size = new System.Drawing.Size(42, 13);
            this.blbModel.TabIndex = 3;
            this.blbModel.Text = "Model: ";
            // 
            // lblTy
            // 
            this.lblTy.AutoSize = true;
            this.lblTy.Location = new System.Drawing.Point(51, 107);
            this.lblTy.Name = "lblTy";
            this.lblTy.Size = new System.Drawing.Size(38, 13);
            this.lblTy.TabIndex = 2;
            this.lblTy.Text = "Type: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name: ";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(39, 45);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(50, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item ID: ";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(604, 491);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(657, 488);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 21);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.modelNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.batchCodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.dataGridView.DataSource = this.assetTableBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(9, 285);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(990, 197);
            this.dataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "itemName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "itemType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // modelNumberDataGridViewTextBoxColumn
            // 
            this.modelNumberDataGridViewTextBoxColumn.DataPropertyName = "ModelNumber";
            this.modelNumberDataGridViewTextBoxColumn.HeaderText = "Model Number";
            this.modelNumberDataGridViewTextBoxColumn.Name = "modelNumberDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vendor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vendor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // batchCodeDataGridViewTextBoxColumn
            // 
            this.batchCodeDataGridViewTextBoxColumn.DataPropertyName = "batchCode";
            this.batchCodeDataGridViewTextBoxColumn.HeaderText = "Batch Code";
            this.batchCodeDataGridViewTextBoxColumn.Name = "batchCodeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "itemDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Purchase Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "frontImg";
            this.dataGridViewImageColumn1.HeaderText = "Front Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "backImg";
            this.dataGridViewImageColumn2.HeaderText = "Back Image";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(74, 489);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(193, 489);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCba
            // 
            this.lblCba.AutoSize = true;
            this.lblCba.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCba.Location = new System.Drawing.Point(14, 524);
            this.lblCba.Name = "lblCba";
            this.lblCba.Size = new System.Drawing.Size(198, 11);
            this.lblCba.TabIndex = 27;
            this.lblCba.Text = "CopyRight Computers and Beyond Africa Ltd.";
            // 
            // lblWeblink
            // 
            this.lblWeblink.AutoSize = true;
            this.lblWeblink.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeblink.Location = new System.Drawing.Point(900, 524);
            this.lblWeblink.Name = "lblWeblink";
            this.lblWeblink.Size = new System.Drawing.Size(99, 12);
            this.lblWeblink.TabIndex = 5;
            this.lblWeblink.TabStop = true;
            this.lblWeblink.Text = "www.cbafrica.ug";
            this.lblWeblink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWeblink_LinkClicked);
            // 
            // AssetForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 538);
            this.Controls.Add(this.lblWeblink);
            this.Controls.Add(this.lblCba);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssetForm";
            this.Text = "CBA Inventory Manager";
        
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label blbModel;
        private System.Windows.Forms.Label lblVendor;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFront;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbFront;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblBatch;
        private DevExpress.XtraEditors.SimpleButton btnFront;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label lblCba;
        private System.Windows.Forms.LinkLabel lblWeblink;
       
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private appData appData;
        private System.Windows.Forms.BindingSource assetTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}

