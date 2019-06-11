using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tp3
{
    public partial class frmAjouterProd : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public frmAjouterProd()
        {
            InitializeComponent();
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void frmAjouterProd_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=ip310;Initial Catalog = BDStock; Integrated Security = True";
 cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";
            this.produitTableAdapter.Fill(this.bDStockDataSet.Produit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment ajouter ce produit ?",
"Ajout d'un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "insert into Produit values (" +
                   txtCode.Text + "," + cmbFourn.SelectedValue.ToString() + ",'" +
                   txtNom.Text + "'," + txtPrix.Text + "," + txtQt.Text + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion effectuée avec succes", "Insertion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
