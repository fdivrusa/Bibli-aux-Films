using System.Windows.Forms;

namespace Bibliothèque
{
    partial class FenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auteur = new System.Windows.Forms.ToolStripMenuItem();
            this.application = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideGénéraleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LbRecherche = new System.Windows.Forms.Label();
            this.RtbRecherche = new System.Windows.Forms.RichTextBox();
            this.GbListe = new System.Windows.Forms.GroupBox();
            this.LbxFilms = new System.Windows.Forms.ListBox();
            this.GbFiche = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbRealisateur = new System.Windows.Forms.Label();
            this.LbActeur = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbGenre = new System.Windows.Forms.Label();
            this.LbTitre = new System.Windows.Forms.Label();
            this.GbResume = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtQuitter = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BtAjouter = new System.Windows.Forms.Button();
            this.BtSupprimer = new System.Windows.Forms.Button();
            this.BtModifier = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.GbListe.SuspendLayout();
            this.GbFiche.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.GbResume.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.informationsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.optionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auteur,
            this.application});
            this.informationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // auteur
            // 
            this.auteur.Name = "auteur";
            this.auteur.Size = new System.Drawing.Size(246, 24);
            this.auteur.Text = "À propos de l\'auteur";
            this.auteur.Click += new System.EventHandler(this.auteur_Click);
            // 
            // application
            // 
            this.application.Name = "application";
            this.application.Size = new System.Drawing.Size(246, 24);
            this.application.Text = "À propos de l\'application";
            this.application.Click += new System.EventHandler(this.application_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFilmToolStripMenuItem,
            this.supprimerUnFilmToolStripMenuItem,
            this.modifierUnFilmToolStripMenuItem,
            this.aideGénéraleToolStripMenuItem});
            this.aideToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aideToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // ajouterUnFilmToolStripMenuItem
            // 
            this.ajouterUnFilmToolStripMenuItem.Name = "ajouterUnFilmToolStripMenuItem";
            this.ajouterUnFilmToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.ajouterUnFilmToolStripMenuItem.Text = "Ajouter un film";
            this.ajouterUnFilmToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFilmToolStripMenuItem_Click);
            // 
            // supprimerUnFilmToolStripMenuItem
            // 
            this.supprimerUnFilmToolStripMenuItem.Name = "supprimerUnFilmToolStripMenuItem";
            this.supprimerUnFilmToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.supprimerUnFilmToolStripMenuItem.Text = "Supprimer un film";
            this.supprimerUnFilmToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnFilmToolStripMenuItem_Click);
            // 
            // modifierUnFilmToolStripMenuItem
            // 
            this.modifierUnFilmToolStripMenuItem.Name = "modifierUnFilmToolStripMenuItem";
            this.modifierUnFilmToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.modifierUnFilmToolStripMenuItem.Text = "Modifier un film";
            this.modifierUnFilmToolStripMenuItem.Click += new System.EventHandler(this.modifierUnFilmToolStripMenuItem_Click);
            // 
            // aideGénéraleToolStripMenuItem
            // 
            this.aideGénéraleToolStripMenuItem.Name = "aideGénéraleToolStripMenuItem";
            this.aideGénéraleToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.aideGénéraleToolStripMenuItem.Text = "Aide générale";
            this.aideGénéraleToolStripMenuItem.Click += new System.EventHandler(this.aideGénéraleToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25062F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74939F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GbFiche, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtQuitter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 624);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GbListe, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(532, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.911447F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.08855F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(272, 539);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.64922F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.35078F));
            this.tableLayoutPanel4.Controls.Add(this.LbRecherche, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.RtbRecherche, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(266, 31);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // LbRecherche
            // 
            this.LbRecherche.AutoSize = true;
            this.LbRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbRecherche.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRecherche.Location = new System.Drawing.Point(3, 0);
            this.LbRecherche.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LbRecherche.Name = "LbRecherche";
            this.LbRecherche.Size = new System.Drawing.Size(91, 26);
            this.LbRecherche.TabIndex = 0;
            this.LbRecherche.Text = "Recherche --> ";
            this.LbRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RtbRecherche
            // 
            this.RtbRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbRecherche.Location = new System.Drawing.Point(100, 3);
            this.RtbRecherche.Name = "RtbRecherche";
            this.RtbRecherche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RtbRecherche.Size = new System.Drawing.Size(163, 25);
            this.RtbRecherche.TabIndex = 1;
            this.RtbRecherche.Text = "";
            this.RtbRecherche.TextChanged += new System.EventHandler(this.RtbRecherche_TextChanged);
            // 
            // GbListe
            // 
            this.GbListe.Controls.Add(this.LbxFilms);
            this.GbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListe.Location = new System.Drawing.Point(3, 40);
            this.GbListe.Name = "GbListe";
            this.GbListe.Size = new System.Drawing.Size(266, 496);
            this.GbListe.TabIndex = 1;
            this.GbListe.TabStop = false;
            this.GbListe.Text = "Liste des Films";
            // 
            // LbxFilms
            // 
            this.LbxFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LbxFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbxFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxFilms.FormattingEnabled = true;
            this.LbxFilms.Location = new System.Drawing.Point(3, 16);
            this.LbxFilms.Name = "LbxFilms";
            this.LbxFilms.ScrollAlwaysVisible = true;
            this.LbxFilms.Size = new System.Drawing.Size(260, 477);
            this.LbxFilms.TabIndex = 0;
            this.LbxFilms.SelectedIndexChanged += new System.EventHandler(this.LbxFilms_SelectedIndexChanged);
            // 
            // GbFiche
            // 
            this.GbFiche.Controls.Add(this.tableLayoutPanel3);
            this.GbFiche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFiche.Location = new System.Drawing.Point(5, 5);
            this.GbFiche.Margin = new System.Windows.Forms.Padding(5);
            this.GbFiche.Name = "GbFiche";
            this.GbFiche.Size = new System.Drawing.Size(512, 542);
            this.GbFiche.TabIndex = 1;
            this.GbFiche.TabStop = false;
            this.GbFiche.Text = "Fiche du Film";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GbResume, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.21839F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.78161F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 523);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.2F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.8F));
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(500, 324);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(5, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.LbTitre, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(174, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.79635F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.20364F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(323, 318);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74133F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25867F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.LbRealisateur, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.LbActeur, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.LbDate, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.LbGenre, 1, 3);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 4;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(317, 240);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réalisateur(s) : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acteurs principaux : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de sortie :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbRealisateur
            // 
            this.LbRealisateur.AutoEllipsis = true;
            this.LbRealisateur.AutoSize = true;
            this.LbRealisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbRealisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbRealisateur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRealisateur.ForeColor = System.Drawing.Color.MediumBlue;
            this.LbRealisateur.Location = new System.Drawing.Point(150, 5);
            this.LbRealisateur.Margin = new System.Windows.Forms.Padding(5);
            this.LbRealisateur.Name = "LbRealisateur";
            this.LbRealisateur.Size = new System.Drawing.Size(162, 50);
            this.LbRealisateur.TabIndex = 3;
            this.LbRealisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbActeur
            // 
            this.LbActeur.AutoEllipsis = true;
            this.LbActeur.AutoSize = true;
            this.LbActeur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbActeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbActeur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbActeur.ForeColor = System.Drawing.Color.MediumBlue;
            this.LbActeur.Location = new System.Drawing.Point(150, 65);
            this.LbActeur.Margin = new System.Windows.Forms.Padding(5);
            this.LbActeur.Name = "LbActeur";
            this.LbActeur.Size = new System.Drawing.Size(162, 50);
            this.LbActeur.TabIndex = 4;
            this.LbActeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbDate
            // 
            this.LbDate.AutoEllipsis = true;
            this.LbDate.AutoSize = true;
            this.LbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.ForeColor = System.Drawing.Color.MediumBlue;
            this.LbDate.Location = new System.Drawing.Point(150, 125);
            this.LbDate.Margin = new System.Windows.Forms.Padding(5);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(162, 50);
            this.LbDate.TabIndex = 5;
            this.LbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 60);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genre(s) :  ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbGenre
            // 
            this.LbGenre.AutoEllipsis = true;
            this.LbGenre.AutoSize = true;
            this.LbGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGenre.ForeColor = System.Drawing.Color.MediumBlue;
            this.LbGenre.Location = new System.Drawing.Point(150, 185);
            this.LbGenre.Margin = new System.Windows.Forms.Padding(5);
            this.LbGenre.Name = "LbGenre";
            this.LbGenre.Size = new System.Drawing.Size(162, 50);
            this.LbGenre.TabIndex = 7;
            this.LbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbTitre
            // 
            this.LbTitre.AutoEllipsis = true;
            this.LbTitre.AutoSize = true;
            this.LbTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbTitre.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitre.ForeColor = System.Drawing.Color.Navy;
            this.LbTitre.Location = new System.Drawing.Point(3, 0);
            this.LbTitre.Name = "LbTitre";
            this.LbTitre.Size = new System.Drawing.Size(317, 72);
            this.LbTitre.TabIndex = 1;
            this.LbTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbResume
            // 
            this.GbResume.Controls.Add(this.richTextBox1);
            this.GbResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbResume.Location = new System.Drawing.Point(5, 335);
            this.GbResume.Margin = new System.Windows.Forms.Padding(5);
            this.GbResume.Name = "GbResume";
            this.GbResume.Size = new System.Drawing.Size(496, 183);
            this.GbResume.TabIndex = 1;
            this.GbResume.TabStop = false;
            this.GbResume.Text = "Résumé du Film";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBox1.MaxLength = 9999999;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(490, 164);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtQuitter
            // 
            this.BtQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtQuitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtQuitter.Location = new System.Drawing.Point(557, 557);
            this.BtQuitter.Margin = new System.Windows.Forms.Padding(35, 5, 35, 5);
            this.BtQuitter.Name = "BtQuitter";
            this.BtQuitter.Size = new System.Drawing.Size(222, 62);
            this.BtQuitter.TabIndex = 2;
            this.BtQuitter.Text = "Quitter";
            this.BtQuitter.UseVisualStyleBackColor = false;
            this.BtQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.BtAjouter, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtSupprimer, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.BtModifier, 2, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 555);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(516, 66);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // BtAjouter
            // 
            this.BtAjouter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAjouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAjouter.Location = new System.Drawing.Point(3, 3);
            this.BtAjouter.Name = "BtAjouter";
            this.BtAjouter.Size = new System.Drawing.Size(166, 60);
            this.BtAjouter.TabIndex = 0;
            this.BtAjouter.Text = "Ajouter un film";
            this.BtAjouter.UseVisualStyleBackColor = false;
            this.BtAjouter.Click += new System.EventHandler(this.BtAjouter_Click);
            // 
            // BtSupprimer
            // 
            this.BtSupprimer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSupprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSupprimer.Location = new System.Drawing.Point(175, 3);
            this.BtSupprimer.Name = "BtSupprimer";
            this.BtSupprimer.Size = new System.Drawing.Size(166, 60);
            this.BtSupprimer.TabIndex = 1;
            this.BtSupprimer.Text = "Supprimer le film";
            this.BtSupprimer.UseVisualStyleBackColor = false;
            this.BtSupprimer.Click += new System.EventHandler(this.BtSupprimer_Click);
            // 
            // BtModifier
            // 
            this.BtModifier.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtModifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtModifier.Location = new System.Drawing.Point(347, 3);
            this.BtModifier.Name = "BtModifier";
            this.BtModifier.Size = new System.Drawing.Size(166, 60);
            this.BtModifier.TabIndex = 2;
            this.BtModifier.Text = "Modifier la fiche";
            this.BtModifier.UseVisualStyleBackColor = false;
            this.BtModifier.Click += new System.EventHandler(this.BtModifier_Click);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(814, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(830, 691);
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibli aux Films";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FenetrePrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FenetrePrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.GbListe.ResumeLayout(false);
            this.GbFiche.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.GbResume.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem réinitialiserToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem informationsToolStripMenuItem;
        private ToolStripMenuItem auteur;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem ajouterUnFilmToolStripMenuItem;
        private ToolStripMenuItem supprimerUnFilmToolStripMenuItem;
        private ToolStripMenuItem modifierUnFilmToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label LbRecherche;
        private GroupBox GbListe;
        private ListBox LbxFilms;
        private GroupBox GbFiche;
        private ToolStripMenuItem application;
        private ToolStripMenuItem aideGénéraleToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label LbTitre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LbRealisateur;
        private Label LbActeur;
        private Label LbDate;
        private Label label7;
        private Label LbGenre;
        private GroupBox GbResume;
        private RichTextBox richTextBox1;
        private RichTextBox RtbRecherche;
        private Button BtQuitter;
        private TableLayoutPanel tableLayoutPanel8;
        private Button BtAjouter;
        private Button BtSupprimer;
        private Button BtModifier;
    }
}

