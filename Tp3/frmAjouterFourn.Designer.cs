namespace Tp3
{
    partial class frmAjouterFourn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterFourn));
            System.Windows.Forms.Label codeFournLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label faxLabel;
            this.bDStockDataSet = new Tp3.BDStockDataSet();
            this.fournisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fournisseurTableAdapter = new Tp3.BDStockDataSetTableAdapters.FournisseurTableAdapter();
            this.tableAdapterManager = new Tp3.BDStockDataSetTableAdapters.TableAdapterManager();
            this.fournisseurBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fournisseurBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnajout = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            codeFournLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingNavigator)).BeginInit();
            this.fournisseurBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDStockDataSet
            // 
            this.bDStockDataSet.DataSetName = "BDStockDataSet";
            this.bDStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fournisseurBindingSource
            // 
            this.fournisseurBindingSource.DataMember = "Fournisseur";
            this.fournisseurBindingSource.DataSource = this.bDStockDataSet;
            // 
            // fournisseurTableAdapter
            // 
            this.fournisseurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = this.fournisseurTableAdapter;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tp3.BDStockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fournisseurBindingNavigator
            // 
            this.fournisseurBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fournisseurBindingNavigator.BindingSource = this.fournisseurBindingSource;
            this.fournisseurBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fournisseurBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fournisseurBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.fournisseurBindingNavigatorSaveItem});
            this.fournisseurBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fournisseurBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fournisseurBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fournisseurBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fournisseurBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fournisseurBindingNavigator.Name = "fournisseurBindingNavigator";
            this.fournisseurBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fournisseurBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.fournisseurBindingNavigator.TabIndex = 0;
            this.fournisseurBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // fournisseurBindingNavigatorSaveItem
            // 
            this.fournisseurBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fournisseurBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fournisseurBindingNavigatorSaveItem.Image")));
            this.fournisseurBindingNavigatorSaveItem.Name = "fournisseurBindingNavigatorSaveItem";
            this.fournisseurBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fournisseurBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.fournisseurBindingNavigatorSaveItem.Click += new System.EventHandler(this.fournisseurBindingNavigatorSaveItem_Click);
            // 
            // codeFournLabel
            // 
            codeFournLabel.AutoSize = true;
            codeFournLabel.Location = new System.Drawing.Point(202, 138);
            codeFournLabel.Name = "codeFournLabel";
            codeFournLabel.Size = new System.Drawing.Size(65, 13);
            codeFournLabel.TabIndex = 1;
            codeFournLabel.Text = "Code Fourn:";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "CodeFourn", true));
            this.txtCode.Location = new System.Drawing.Point(279, 135);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Location = new System.Drawing.Point(202, 164);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(71, 13);
            nomPrenomLabel.TabIndex = 3;
            nomPrenomLabel.Text = "Nom Prenom:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "NomPrenom", true));
            this.txtNom.Location = new System.Drawing.Point(279, 161);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(202, 190);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 5;
            adresseLabel.Text = "Adresse:";
            // 
            // txtAdr
            // 
            this.txtAdr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Adresse", true));
            this.txtAdr.Location = new System.Drawing.Point(279, 187);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(100, 20);
            this.txtAdr.TabIndex = 6;
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Location = new System.Drawing.Point(202, 216);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(61, 13);
            telephoneLabel.TabIndex = 7;
            telephoneLabel.Text = "Telephone:";
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Telephone", true));
            this.txtTel.Location = new System.Drawing.Point(279, 213);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 8;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(202, 242);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 9;
            faxLabel.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fournisseurBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(279, 239);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Premier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Précedent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Dernier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(78, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Nouveau";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnajout
            // 
            this.btnajout.Location = new System.Drawing.Point(205, 306);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(75, 23);
            this.btnajout.TabIndex = 16;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(339, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Supprimer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(456, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Modifier";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(596, 306);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Enregistrer";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // frmAjouterFourn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codeFournLabel);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(nomPrenomLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.txtAdr);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.fournisseurBindingNavigator);
            this.Name = "frmAjouterFourn";
            this.Text = "frmAjouterFourn";
            this.Load += new System.EventHandler(this.frmAjouterFourn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurBindingNavigator)).EndInit();
            this.fournisseurBindingNavigator.ResumeLayout(false);
            this.fournisseurBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDStockDataSet bDStockDataSet;
        private System.Windows.Forms.BindingSource fournisseurBindingSource;
        private BDStockDataSetTableAdapters.FournisseurTableAdapter fournisseurTableAdapter;
        private BDStockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fournisseurBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fournisseurBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}