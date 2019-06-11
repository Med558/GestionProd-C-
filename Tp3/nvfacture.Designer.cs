namespace Tp3
{
    partial class nvfacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nvfacture));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAjoutFact = new System.Windows.Forms.Button();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bDStockDataSet = new Tp3.BDStockDataSet();
            this.ligneFactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneFactureTableAdapter = new Tp3.BDStockDataSetTableAdapters.LigneFactureTableAdapter();
            this.tableAdapterManager = new Tp3.BDStockDataSetTableAdapters.TableAdapterManager();
            this.ligneFactureBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ligneFactureBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRet = new System.Windows.Forms.TextBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.grpLigne = new System.Windows.Forms.GroupBox();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneFactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneFactureBindingNavigator)).BeginInit();
            this.ligneFactureBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpLigne.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(237, 123);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnAjoutFact
            // 
            this.btnAjoutFact.Location = new System.Drawing.Point(168, 244);
            this.btnAjoutFact.Name = "btnAjoutFact";
            this.btnAjoutFact.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutFact.TabIndex = 5;
            this.btnAjoutFact.Text = "Ajouter";
            this.btnAjoutFact.UseVisualStyleBackColor = true;
            this.btnAjoutFact.Click += new System.EventHandler(this.btnAjoutFact_Click);
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(356, 244);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(75, 23);
            this.btnQ1.TabIndex = 6;
            this.btnQ1.Text = "Quitter";
            this.btnQ1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Supp Ligne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDStockDataSet
            // 
            this.bDStockDataSet.DataSetName = "BDStockDataSet";
            this.bDStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligneFactureBindingSource
            // 
            this.ligneFactureBindingSource.DataMember = "LigneFacture";
            this.ligneFactureBindingSource.DataSource = this.bDStockDataSet;
            // 
            // ligneFactureTableAdapter
            // 
            this.ligneFactureTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.FournisseurTableAdapter = null;
            this.tableAdapterManager.LigneFactureTableAdapter = this.ligneFactureTableAdapter;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tp3.BDStockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ligneFactureBindingNavigator
            // 
            this.ligneFactureBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ligneFactureBindingNavigator.BindingSource = this.ligneFactureBindingSource;
            this.ligneFactureBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ligneFactureBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ligneFactureBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ligneFactureBindingNavigatorSaveItem});
            this.ligneFactureBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ligneFactureBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ligneFactureBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ligneFactureBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ligneFactureBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ligneFactureBindingNavigator.Name = "ligneFactureBindingNavigator";
            this.ligneFactureBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ligneFactureBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ligneFactureBindingNavigator.TabIndex = 15;
            this.ligneFactureBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ligneFactureBindingNavigatorSaveItem
            // 
            this.ligneFactureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ligneFactureBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ligneFactureBindingNavigatorSaveItem.Image")));
            this.ligneFactureBindingNavigatorSaveItem.Name = "ligneFactureBindingNavigatorSaveItem";
            this.ligneFactureBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ligneFactureBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.ligneFactureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(97, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 124);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeFacture";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeFacture";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeProduit";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodeProduit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantite";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantite";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Enregistrer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Retenue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Totale facture ";
            // 
            // txtRet
            // 
            this.txtRet.Location = new System.Drawing.Point(107, 205);
            this.txtRet.Name = "txtRet";
            this.txtRet.Size = new System.Drawing.Size(100, 20);
            this.txtRet.TabIndex = 20;
            this.txtRet.Validating += new System.ComponentModel.CancelEventHandler(this.txtRet_Validating);
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(348, 204);
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.Size = new System.Drawing.Size(100, 20);
            this.txtTot.TabIndex = 21;
            // 
            // grpLigne
            // 
            this.grpLigne.Controls.Add(this.cmbProd);
            this.grpLigne.Controls.Add(this.button2);
            this.grpLigne.Controls.Add(this.txtQt);
            this.grpLigne.Controls.Add(this.txtPrix);
            this.grpLigne.Controls.Add(this.label5);
            this.grpLigne.Controls.Add(this.label4);
            this.grpLigne.Controls.Add(this.label3);
            this.grpLigne.Controls.Add(this.txtTot);
            this.grpLigne.Controls.Add(this.txtRet);
            this.grpLigne.Controls.Add(this.button1);
            this.grpLigne.Controls.Add(this.label7);
            this.grpLigne.Controls.Add(this.label6);
            this.grpLigne.Controls.Add(this.button3);
            this.grpLigne.Controls.Add(this.dataGridView1);
            this.grpLigne.Location = new System.Drawing.Point(18, 317);
            this.grpLigne.Name = "grpLigne";
            this.grpLigne.Size = new System.Drawing.Size(754, 319);
            this.grpLigne.TabIndex = 22;
            this.grpLigne.TabStop = false;
            this.grpLigne.Text = "Les Lignes";
            this.grpLigne.Visible = false;
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(138, 30);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(121, 21);
            this.cmbProd.TabIndex = 28;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbProd.SelectionChangeCommitted += new System.EventHandler(this.cmbProd_SelectionChangeCommitted);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ajouter Ligne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(503, 33);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(100, 20);
            this.txtQt.TabIndex = 26;
            this.txtQt.Validating += new System.ComponentModel.CancelEventHandler(this.txtQt_Validating);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(330, 33);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.ReadOnly = true;
            this.txtPrix.Size = new System.Drawing.Size(100, 20);
            this.txtPrix.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantité ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Prix Unit ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Produit";
            // 
            // nvfacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.grpLigne);
            this.Controls.Add(this.ligneFactureBindingNavigator);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.btnAjoutFact);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nvfacture";
            this.Text = "nvfacture";
            this.Load += new System.EventHandler(this.nvfacture_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneFactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligneFactureBindingNavigator)).EndInit();
            this.ligneFactureBindingNavigator.ResumeLayout(false);
            this.ligneFactureBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpLigne.ResumeLayout(false);
            this.grpLigne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAjoutFact;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button button1;
        private BDStockDataSet bDStockDataSet;
        private System.Windows.Forms.BindingSource ligneFactureBindingSource;
        private BDStockDataSetTableAdapters.LigneFactureTableAdapter ligneFactureTableAdapter;
        private BDStockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ligneFactureBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ligneFactureBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRet;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.GroupBox grpLigne;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}