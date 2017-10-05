using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AssetManager.appDataTableAdapters;

namespace AssetManager
{
    public partial class AssetForm : DevExpress.XtraEditors.XtraForm
    {
        public AssetForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtName.Focus();
                appData.AssetTable.AddAssetTableRow(appData.AssetTable.NewAssetTableRow());
                assetTableBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, @MessageBoxIcon.Error);
                assetTableBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                assetTableBindingSource.EndEdit();
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                assetTableBindingSource.ResetBindings(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            assetTableBindingSource.ResetBindings(false);
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                Filter = "Image files |*.jpg; *.jpeg; *.jfif; *.png; *.jpg; *.jpeg; *.jpe; *.png",
                ValidateNames = true, Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbFront.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                Filter = "Image files |*.jpg; *.jpeg; *.jpe; *.png; *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                ValidateNames = true, Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbBack.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void lblWeblink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string url = "http:www.cbafrica.ug";
            System.Diagnostics.Process.Start(url);
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)30)
            {
                assetTableBindingSource.DataSource = appData.AssetTable;
                var assetTableAdapter = new AssetTableTableAdapter();
                assetTableAdapter.Fill(this.appData.AssetTable); 
            }
            else
            {
                var query = from q in this.appData.AssetTable
                    where q.itemName.Contains(txtSearch.Text)
                    || q.itemType.Contains(txtSearch.Text)
                    || q.Vendor.Contains(txtSearch.Text)
                    select q;
                appDataBindingSource.DataSource = query.ToList();
            }}

        private void AssetForm_Load(object sender, EventArgs e){
            assetTableBindingSource.DataSource = appData.AssetTable;
            var assetTableAdapter = new AssetTableTableAdapter();assetTableAdapter.Fill(this.appData.AssetTable);
        }
    }
}
