namespace Tp3
{
    partial class frmAjouterProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterProd));
            System.Windows.Forms.Label codeProduitLabel;
            System.Windows.Forms.Label codeFournLabel;
            System.Windows.Forms.Label nomProduitLabel;
            System.Windows.Forms.Label prixUnitaireLabel;
            System.Windows.Forms.Label qtEnStockLabel;
            this.bDStockDataSet = new Tp3.BDStockDataSet();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new Tp3.BDStockDataSetTableAdapters.ProduitTableAdapter();
            this.tableAdapterManager = new Tp3.BDStockDataSetTableAdapters.TableAdapterManager();
            this.produitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbFourn = new System.Windows.Forms.ComboBox();
            codeProduitLabel = new System.Windows.Forms.Label();
            codeFournLabel = new System.Windows.Forms.Label();
            nomProduitLabel = new System.Windows.Forms.Label();
            prixUnitaireLabel = new System.Windows.Forms.Label();
            qtEnStockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).BeginInit();
            this.produitBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bDStockDataSet
            // 
            this.bDStockDataSet.DataSetName = "BDStockDataSet";
            this.bDStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.bDStockDataSet;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.LigneFactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = this.produitTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tp3.BDStockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produitBindingNavigator
            // 
            this.produitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produitBindingNavigator.BindingSource = this.produitBindingSource;
            this.produitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produitBindingNavigatorSaveItem});
            this.produitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produitBindingNavigator.Name = "produitBindingNavigator";
            this.produitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produitBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.produitBindingNavigator.TabIndex = 0;
            this.produitBindingNavigator.Text = "bindingNavigator1";
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
            // produitBindingNavigatorSaveItem
            // 
            this.produitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produitBindingNavigatorSaveItem.Image")));
            this.produitBindingNavigatorSaveItem.Name = "produitBindingNavigatorSaveItem";
            this.produitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produitBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.produitBindingNavigatorSaveItem.Click += new System.EventHandler(this.produitBindingNavigatorSaveItem_Click);
            // 
            // codeProduitLabel
            // 
            codeProduitLabel.AutoSize = true;
            codeProduitLabel.Location = new System.Drawing.Point(260, 181);
            codeProduitLabel.Name = "codeProduitLabel";
            codeProduitLabel.Size = new System.Drawing.Size(71, 13);
            codeProduitLabel.TabIndex = 1;
            codeProduitLabel.Text = "Code Produit:";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "CodeProduit", true));
            this.txtCode.Location = new System.Drawing.Point(337, 178);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 2;
            // 
            // codeFournLabel
            // 
            codeFournLabel.AutoSize = true;
            codeFournLabel.Location = new System.Drawing.Point(239, 207);
            codeFournLabel.Name = "codeFournLabel";
            codeFournLabel.Size = new System.Drawing.Size(92, 13);
            codeFournLabel.TabIndex = 3;
            codeFournLabel.Text = "Nom Fournisseur :";
            // 
            // nomProduitLabel
            // 
            nomProduitLabel.AutoSize = true;
            nomProduitLabel.Location = new System.Drawing.Point(260, 233);
            nomProduitLabel.Name = "nomProduitLabel";
            nomProduitLabel.Size = new System.Drawing.Size(68, 13);
            nomProduitLabel.TabIndex = 5;
            nomProduitLabel.Text = "Nom Produit:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "NomProduit", true));
            this.txtNom.Location = new System.Drawing.Point(337, 230);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 6;
            // 
            // prixUnitaireLabel
            // 
            prixUnitaireLabel.AutoSize = true;
            prixUnitaireLabel.Location = new System.Drawing.Point(260, 259);
            prixUnitaireLabel.Name = "prixUnitaireLabel";
            prixUnitaireLabel.Size = new System.Drawing.Size(66, 13);
            prixUnitaireLabel.TabIndex = 7;
            prixUnitaireLabel.Text = "Prix Unitaire:";
            // 
            // txtPrix
            // 
            this.txtPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "PrixUnitaire", true));
            this.txtPrix.Location = new System.Drawing.Point(337, 256);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 8;
            // 
            // qtEnStockLabel
            // 
            qtEnStockLabel.AutoSize = true;
            qtEnStockLabel.Location = new System.Drawing.Point(260, 285);
            qtEnStockLabel.Name = "qtEnStockLabel";
            qtEnStockLabel.Size = new System.Drawing.Size(68, 13);
            qtEnStockLabel.TabIndex = 9;
            qtEnStockLabel.Text = "Qt En Stock:";
            // 
            // txtQt
            // 
            this.txtQt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produitBindingSource, "QtEnStock", true));
            this.txtQt.Location = new System.Drawing.Point(337, 282);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(100, 20);
            this.txtQt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbFourn
            // 
            this.cmbFourn.FormattingEnabled = true;
            this.cmbFourn.Location = new System.Drawing.Point(338, 205);
            this.cmbFourn.Name = "cmbFourn";
            this.cmbFourn.Size = new System.Drawing.Size(99, 21);
            this.cmbFourn.TabIndex = 13;
            // 
            // frmAjouterProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbFourn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codeProduitLabel);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(codeFournLabel);
            this.Controls.Add(nomProduitLabel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(prixUnitaireLabel);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(qtEnStockLabel);
            this.Controls.Add(this.txtQt);
            this.Controls.Add(this.produitBindingNavigator);
            this.Name = "frmAjouterProd";
            this.Text = "frmAjouterProd";
            this.Load += new System.EventHandler(this.frmAjouterProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingNavigator)).EndInit();
            this.produitBindingNavigator.ResumeLayout(false);
            this.produitBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDStockDataSet bDStockDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private BDStockDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private BDStockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produitBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produitBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbFourn;
    }
}