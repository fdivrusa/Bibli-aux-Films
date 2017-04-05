namespace Bibliothèque
{
    partial class FenetreEncodage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetreEncodage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtEnregistrerFermer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RtbResume = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtParcourir = new System.Windows.Forms.Button();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.TbTitre = new System.Windows.Forms.TextBox();
            this.TbRealisateurs = new System.Windows.Forms.TextBox();
            this.TbActeurs = new System.Windows.Forms.TextBox();
            this.TbGenre = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23747F));
            this.tableLayoutPanel2.Controls.Add(this.BtEnregistrerFermer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 426);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(457, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtEnregistrerFermer
            // 
            this.BtEnregistrerFermer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtEnregistrerFermer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtEnregistrerFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEnregistrerFermer.Location = new System.Drawing.Point(80, 2);
            this.BtEnregistrerFermer.Margin = new System.Windows.Forms.Padding(80, 2, 80, 2);
            this.BtEnregistrerFermer.Name = "BtEnregistrerFermer";
            this.BtEnregistrerFermer.Size = new System.Drawing.Size(297, 38);
            this.BtEnregistrerFermer.TabIndex = 9;
            this.BtEnregistrerFermer.Text = "Enregistrer et fermer";
            this.BtEnregistrerFermer.UseVisualStyleBackColor = false;
            this.BtEnregistrerFermer.Click += new System.EventHandler(this.BtEnregistrerFermer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RtbResume);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumé du Film";
            // 
            // RtbResume
            // 
            this.RtbResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbResume.Location = new System.Drawing.Point(3, 16);
            this.RtbResume.Name = "RtbResume";
            this.RtbResume.Size = new System.Drawing.Size(437, 155);
            this.RtbResume.TabIndex = 8;
            this.RtbResume.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.24691F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.75309F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Dtp, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.TbTitre, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.TbRealisateurs, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.TbActeurs, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.TbGenre, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(457, 237);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Réalisateur(s) :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acteurs principaux :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre(s) :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de sortie :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dtp
            // 
            this.Dtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dtp.Location = new System.Drawing.Point(143, 163);
            this.Dtp.Margin = new System.Windows.Forms.Padding(5, 7, 3, 3);
            this.Dtp.MaxDate = new System.DateTime(3822, 3, 31, 0, 0, 0, 0);
            this.Dtp.Name = "Dtp";
            this.Dtp.Size = new System.Drawing.Size(311, 20);
            this.Dtp.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 42);
            this.label6.TabIndex = 6;
            this.label6.Text = "Image :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.73606F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.26394F));
            this.tableLayoutPanel4.Controls.Add(this.BtParcourir, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TbPath, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(141, 198);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 36);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // BtParcourir
            // 
            this.BtParcourir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtParcourir.Location = new System.Drawing.Point(188, 5);
            this.BtParcourir.Margin = new System.Windows.Forms.Padding(5);
            this.BtParcourir.Name = "BtParcourir";
            this.BtParcourir.Size = new System.Drawing.Size(120, 26);
            this.BtParcourir.TabIndex = 6;
            this.BtParcourir.Text = "Parcourir";
            this.BtParcourir.UseVisualStyleBackColor = true;
            this.BtParcourir.Click += new System.EventHandler(this.BtParcourir_Click);
            // 
            // TbPath
            // 
            this.TbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPath.Location = new System.Drawing.Point(3, 7);
            this.TbPath.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.TbPath.Name = "TbPath";
            this.TbPath.ReadOnly = true;
            this.TbPath.Size = new System.Drawing.Size(177, 20);
            this.TbPath.TabIndex = 1;
            this.TbPath.TabStop = false;
            // 
            // TbTitre
            // 
            this.TbTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbTitre.Location = new System.Drawing.Point(143, 8);
            this.TbTitre.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.TbTitre.MaxLength = 100;
            this.TbTitre.Name = "TbTitre";
            this.TbTitre.Size = new System.Drawing.Size(311, 20);
            this.TbTitre.TabIndex = 1;
            // 
            // TbRealisateurs
            // 
            this.TbRealisateurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbRealisateurs.Location = new System.Drawing.Point(143, 46);
            this.TbRealisateurs.Margin = new System.Windows.Forms.Padding(5, 7, 3, 3);
            this.TbRealisateurs.MaxLength = 70;
            this.TbRealisateurs.Name = "TbRealisateurs";
            this.TbRealisateurs.Size = new System.Drawing.Size(311, 20);
            this.TbRealisateurs.TabIndex = 2;
            // 
            // TbActeurs
            // 
            this.TbActeurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbActeurs.Location = new System.Drawing.Point(143, 86);
            this.TbActeurs.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.TbActeurs.MaxLength = 70;
            this.TbActeurs.Name = "TbActeurs";
            this.TbActeurs.Size = new System.Drawing.Size(311, 20);
            this.TbActeurs.TabIndex = 3;
            // 
            // TbGenre
            // 
            this.TbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbGenre.Location = new System.Drawing.Point(143, 125);
            this.TbGenre.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.TbGenre.MaxLength = 70;
            this.TbGenre.Name = "TbGenre";
            this.TbGenre.Size = new System.Drawing.Size(311, 20);
            this.TbGenre.TabIndex = 4;
            // 
            // FenetreEncodage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenetreEncodage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encodage";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtEnregistrerFermer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox RtbResume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtParcourir;
        private System.Windows.Forms.TextBox TbPath;
        private System.Windows.Forms.TextBox TbTitre;
        private System.Windows.Forms.TextBox TbRealisateurs;
        private System.Windows.Forms.TextBox TbActeurs;
        private System.Windows.Forms.TextBox TbGenre;
    }
}