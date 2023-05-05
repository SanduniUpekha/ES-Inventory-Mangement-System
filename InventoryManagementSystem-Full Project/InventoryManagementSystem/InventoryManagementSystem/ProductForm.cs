using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Documents\dbMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid,pname,pprice,pdescription,pcategory) LIKE '%"+txtSearch.Text+"%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductModuleForm formModule = new ProductModuleForm();
            formModule.btnSave.Enabled = true;
            formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductModuleForm userModule = new ProductModuleForm();
                userModule.lblPid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtPQty.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtPDes.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.comboCat.Text = dgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been deleted!");
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }
}
