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
using CrystalDecisions.CrystalReports.Engine;
namespace Tp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAjouterClient()).Show();
           // this.Hide();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Listedesclient()).Show();
           // this.Hide();
        }

        private void ajouterUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAjouterFourn()).Show();
          //  this.Hide();
        }

        private void listeDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new listefournisseur()).Show();
           // this.Hide();
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAjouterProd()).Show();
           // this.Hide();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmListeProd()).Show();
           // this.Hide();
        }

        private void créerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new nvfacture()).Show();
            // this.Hide();
        }

        private void rechercherUnPrduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmFindProd()).Show();
            // this.Hide();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection cnx;
            SqlCommand cmd;
            SqlDataAdapter adap;
            DataSet dset;
            ReportDocument rpt;
            rpt = new CrystalReport1();
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=ip310;Initial Catalog = BDStock; Integrated Security = True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "client");
            rpt.SetDataSource(dset.Tables[0]);
            frmRapClient frm = new frmRapClient(rpt);
            frm.ShowDialog();
        }

        private void listeDesFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new listedesfactures().Show();
        }
    }
}
