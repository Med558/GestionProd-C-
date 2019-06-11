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
    public partial class frmFindProd : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataSet dset2;
        public frmFindProd()
        {
            InitializeComponent();
        }

        private void produitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void frmFindProd_Load(object sender, EventArgs e)
        {
            this.produitTableAdapter.Fill(this.bDStockDataSet.Produit);
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=ip310;Initial Catalog = BDStock; Integrated Security = True";
            cnx.Open();
            this.produitTableAdapter.Fill(this.bDStockDataSet.Produit);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdbnom.Checked)
            {
                cmd = new SqlCommand();
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and NomProduit like('" + textBox1.Text + "%')";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset = new DataSet();
                adap.Fill(dset, "Produit");
                produitDataGridView.DataSource = dset.Tables[0];
            }
            else if (rdbcode.Checked)
            {

                cmd = new SqlCommand();
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and CodeProduit like('" + textBox1.Text + "%')";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset = new DataSet();
                adap.Fill(dset, "Produit");
                produitDataGridView.DataSource = dset.Tables[0];

            }
        }
    }
}
