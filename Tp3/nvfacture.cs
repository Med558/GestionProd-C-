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
    public partial class nvfacture : Form
    {
        SqlConnection cnx;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataAdapter adap, adap2, adap3;
        SqlDataReader dread;
        DataSet dset, dset2, dset3;
        SqlCommandBuilder cb;
        DataRow dtr;
        int qt;
        long codeFacture;
        float t = 0;

        private void cmbProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmd.CommandText = "select CodeProduit, PrixUnitaire,QtEnStock from Produit where CodeProduit = " + cmbProd.SelectedValue.ToString();
            cmd.Connection = cnx;
            dread = cmd.ExecuteReader();
            dread.Read();
            txtPrix.Text = dread[1].ToString();
            txtQt.Text = dread[2].ToString();
            qt = (int)dread[2];
            dread.Close();

        }

        private void txtQt_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(txtQt.Text) > qt)
            {
                MessageBox.Show("qantité en stock insuffisante pour la quantité demandé");
               
                txtQt.Text = qt.ToString();
                txtQt.Focus();
            }
        }

        private void btnAjoutFact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment ajouter cette facture ? ", "Ajout d'une Facture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //insertion de la facture dans la table facture
                    cmd.CommandText = "insert into Facture(CodeClient,DateFacture) values(" + cmbClient.SelectedValue.ToString() + ", '" + dateTimePicker1.Value.Date.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    //Afficher la deuxième partie de facture
                    this.Height = 640;
                    grpLigne.Visible = true;
                    //recupérer le code de la facture
                    cmd.CommandText = "select max(codeFacture) from Facture;";
                    codeFacture = (long)cmd.ExecuteScalar();
                    //créer le dataset pour les lignes de la facture
                    cmd2 = new SqlCommand();
                    cmd2.CommandText = "select * from LigneFacture where codeFacture = " + codeFacture.ToString();
                    cmd2.Connection = cnx;
                    adap2 = new SqlDataAdapter(cmd2);
                    dset2 = new DataSet();
                    //recupérer les clés de la table
                    adap2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adap2.Fill(dset2, "LigneFacture");
                    dataGridView1.DataSource = dset2.Tables[0];
                    btnAjoutFact.Enabled = false;
                    // btnQ1.Enabled = false;
                    //btnAcc.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtRet_Validating(object sender, CancelEventArgs e)
        {
            //mettre à jour le total de la facture
            txtTot.Text = (float.Parse(txtRet.Text) + t).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment enregistrer la facture ? ", "Ajout d'une Facture", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
                {
                    //Enregistrer les de la factures dans la base de données
                    cb = new SqlCommandBuilder(adap2);
                    adap2.Update(dset2, "LigneFacture");
                    cb = new SqlCommandBuilder(adap3);
                    //mettre à jours la liste des produits (quantité en stock)
                    adap3.Update(dset3, "Produit");
                    //ajouter le retenue dans la table facture
                    cmd.CommandText = "update Facture set retenue=" + txtRet.Text +
                   " where codeFacture=" + codeFacture.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Facture enregistrée");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nvfacture_Load_1(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=ip310;Initial Catalog = BDStock; Integrated Security = True";
            cnx.Open();
            //commande pour charger la liste des clients
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeClient, cast(Nom as varchar(20)) + ' ' + cast(prenom as varchar(20)) as NomPrenom from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Client");
            cmbClient.DataSource = dset.Tables[0];
            cmbClient.DisplayMember = "NomPrenom";
            cmbClient.ValueMember = "CodeClient";
            //commande pour charger la liste des Produits
            cmd3 = new SqlCommand();
            cmd3.CommandText = "select CodeProduit, NomProduit ,QtEnStock from Produit where QtEnStock > 0; ";
            cmd3.Connection = cnx;
            adap3 = new SqlDataAdapter(cmd3);
            dset3 = new DataSet();
            adap3.Fill(dset3, "Produit");
            cmbProd.DataSource = dset3.Tables[0];
            cmbProd.DisplayMember = "NomProduit";
            cmbProd.ValueMember = "CodeProduit";
            cmbProd.SelectedIndex = -1;
            cmbClient.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentRow.Index;
                long code =
               long.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                int qt =
               int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                float p;
                cmd = cnx.CreateCommand();
                //création d'une requete avec parametres
                cmd.CommandText = "select PrixUnitaire from Produit where CodeProduit = @code";
                //definition d'un nouveau parametre
                cmd.Parameters.Add("@code", SqlDbType.BigInt);
                //préparer la requete pour le serveur
                cmd.Prepare();
                cmd.Parameters["@code"].Value = code;
                p = float.Parse(cmd.ExecuteScalar().ToString());
                t -= p * qt;
                txtTot.Text = (t - float.Parse(txtRet.Text)).ToString();
                dset2.Tables[0].Rows[i].Delete();
                dset2.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProd.SelectedIndex != -1 && int.Parse(txtQt.Text) > 0)
                {
                    dtr = dset2.Tables[0].NewRow();
                    dtr[0] = codeFacture;
                    dtr[1] = int.Parse(cmbProd.SelectedValue.ToString());
                    dtr[2] = int.Parse(txtQt.Text);
                    dset2.Tables[0].Rows.Add(dtr);
                    //mettre à jours la quantité en stock du produit ajouté
                    dset3.Tables[0].Rows[cmbProd.SelectedIndex][2] =
                   (int.Parse(dset3.Tables[0].Rows[cmbProd.SelectedIndex][2].ToString
                   ()) - int.Parse(txtQt.Text)).ToString();
                    t += float.Parse(txtQt.Text) * float.Parse(txtPrix.Text);
                    txtTot.Text = t.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


            public nvfacture()
        {
            InitializeComponent();
        }

        private void nvfacture_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog = BDStock; Integrated Security = True";
            cnx.Open();
            //commande pour charger la liste des clients
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeClient, cast(Nom as varchar(20)) + ' '+ cast(prenom as varchar(20)) as NomPrenom from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Client");
            cmbClient.DataSource = dset.Tables[0];
            cmbClient.DisplayMember = "NomPrenom";
            cmbClient.ValueMember = "CodeClient";
            //commande pour charger la liste des Produits
            cmd3 = new SqlCommand();
            cmd3.CommandText = "select CodeProduit, NomProduit ,QtEnStock from Produit where QtEnStock > 0; ";
cmd3.Connection = cnx;
            adap3 = new SqlDataAdapter(cmd3);
            dset3 = new DataSet();
            adap3.Fill(dset3, "Produit");
            cmbProd.DataSource = dset3.Tables[0];
            cmbProd.DisplayMember = "NomProduit";
            cmbProd.ValueMember = "CodeProduit";
            cmbProd.SelectedIndex = -1;
            cmbClient.SelectedIndex = -1;
        }

        private void ligneFactureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ligneFactureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }
    }
}
