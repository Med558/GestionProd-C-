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

namespace Tp3
{
    
    public partial class listedesfactures : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlDataAdapter adap1;

        SqlCommandBuilder cb;
        DataSet dset;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer cette Facture ? ", "Confirmer suppression", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
                {

                    cmd.CommandText = "delete from Facture where CodeFacture=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression effectuée avec succes", "Suppression");

                    adap = new SqlDataAdapter(cmd);



                    int i = dataGridView1.CurrentRow.Index;
                    dset.Tables[0].Rows[i].Delete();
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Facture");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        public listedesfactures()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listedesfactures_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=ip310;Initial Catalog = BDStock; Integrated Security = True";
            cnx.Open();
            cmd = new SqlCommand();

            cmd.CommandText = "select f.codeFacture, CAST(c.Nom AS nvarchar) as NomClient, CAST(c.Prenom AS nvarchar) as PrenomClient,dateFacture, retenue,SUM(p.PrixUnitaire * lf.Quantite) as Total ,SUM(p.PrixUnitaire * lf.Quantite) - retenue as 'Net à payer' from Facture f, Client c, ligneFacture lf, produit p where f.codeClient = c.codeClient and lf.codeFacture = f.codeFacture and lf.codeProduit = p.codeProduit group by f.codeFacture, CAST(c.Nom AS nvarchar),CAST(c.Prenom AS nvarchar),dateFacture, retenue ";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "ligneFacture");
            dataGridView1.DataSource = dset.Tables[0];
        }
    }
}
