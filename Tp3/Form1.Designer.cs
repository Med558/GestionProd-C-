namespace Tp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnPrduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.factureToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listeDesClientsToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientToolStripMenuItem.Text = "Clients";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.listeDesFournisseursToolStripMenuItem});
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournisseurToolStripMenuItem.Text = "Fournisseur";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un fournisseur";
            this.ajouterUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFournisseurToolStripMenuItem_Click);
            // 
            // listeDesFournisseursToolStripMenuItem
            // 
            this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
            this.listeDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesFournisseursToolStripMenuItem.Text = "Liste des fournisseurs";
            this.listeDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.listeDesFournisseursToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProduitToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem,
            this.rechercherUnPrduitToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            this.ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            this.ajouterUnProduitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ajouterUnProduitToolStripMenuItem.Text = "Ajouter un produit";
            this.ajouterUnProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProduitToolStripMenuItem_Click);
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des produits";
            this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProduitsToolStripMenuItem_Click);
            // 
            // rechercherUnPrduitToolStripMenuItem
            // 
            this.rechercherUnPrduitToolStripMenuItem.Name = "rechercherUnPrduitToolStripMenuItem";
            this.rechercherUnPrduitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rechercherUnPrduitToolStripMenuItem.Text = "Rechercher un prduit";
            this.rechercherUnPrduitToolStripMenuItem.Click += new System.EventHandler(this.rechercherUnPrduitToolStripMenuItem_Click);
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUneFactureToolStripMenuItem,
            this.listeDesFactureToolStripMenuItem,
            this.afficherFactureToolStripMenuItem});
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.factureToolStripMenuItem.Text = "Factures";
            // 
            // créerUneFactureToolStripMenuItem
            // 
            this.créerUneFactureToolStripMenuItem.Name = "créerUneFactureToolStripMenuItem";
            this.créerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.créerUneFactureToolStripMenuItem.Text = "Créer une facture";
            this.créerUneFactureToolStripMenuItem.Click += new System.EventHandler(this.créerUneFactureToolStripMenuItem_Click);
            // 
            // listeDesFactureToolStripMenuItem
            // 
            this.listeDesFactureToolStripMenuItem.Name = "listeDesFactureToolStripMenuItem";
            this.listeDesFactureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesFactureToolStripMenuItem.Text = "Liste des Facture";
            this.listeDesFactureToolStripMenuItem.Click += new System.EventHandler(this.listeDesFactureToolStripMenuItem_Click);
            // 
            // afficherFactureToolStripMenuItem
            // 
            this.afficherFactureToolStripMenuItem.Name = "afficherFactureToolStripMenuItem";
            this.afficherFactureToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.afficherFactureToolStripMenuItem.Text = "Afficher facture";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.imprimerToolStripMenuItem.Text = "Imprimer liste des clients";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnPrduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    }
}

