using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3
{
    public partial class Listedesclient : Form
    {
        public Listedesclient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void Listedesclient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDStockDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.bDStockDataSet.Client);

        }
    }
}
