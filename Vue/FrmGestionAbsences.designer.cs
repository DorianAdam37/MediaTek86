
namespace MediaTek86.Vue
{
    partial class frmGestionAbsences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionAbsences));
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.lblListeAbsences = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblAdministrationAbs = new System.Windows.Forms.Label();
            this.lblGestionAbsences = new System.Windows.Forms.Label();
            this.lblMotifs = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblInfosAAbsences = new System.Windows.Forms.Label();
            this.btnAjouterAbs = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnModifierAbs = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(155, 111);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(361, 266);
            this.dgvAbsences.TabIndex = 0;
            this.dgvAbsences.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsences_CellEnter);
            // 
            // lblListeAbsences
            // 
            this.lblListeAbsences.BackColor = System.Drawing.Color.MediumPurple;
            this.lblListeAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeAbsences.ForeColor = System.Drawing.Color.White;
            this.lblListeAbsences.Location = new System.Drawing.Point(190, 94);
            this.lblListeAbsences.Name = "lblListeAbsences";
            this.lblListeAbsences.Size = new System.Drawing.Size(303, 23);
            this.lblListeAbsences.TabIndex = 1;
            this.lblListeAbsences.Text = "Liste des absences";
            this.lblListeAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFin
            // 
            this.lblFin.BackColor = System.Drawing.Color.Transparent;
            this.lblFin.Location = new System.Drawing.Point(37, 605);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(100, 23);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Date de fin";
            // 
            // lblDebut
            // 
            this.lblDebut.BackColor = System.Drawing.Color.Transparent;
            this.lblDebut.Location = new System.Drawing.Point(37, 557);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(100, 23);
            this.lblDebut.TabIndex = 3;
            this.lblDebut.Text = "Date de début";
            // 
            // lblAdministrationAbs
            // 
            this.lblAdministrationAbs.BackColor = System.Drawing.Color.MediumPurple;
            this.lblAdministrationAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrationAbs.ForeColor = System.Drawing.Color.White;
            this.lblAdministrationAbs.Location = new System.Drawing.Point(348, 454);
            this.lblAdministrationAbs.Name = "lblAdministrationAbs";
            this.lblAdministrationAbs.Size = new System.Drawing.Size(283, 23);
            this.lblAdministrationAbs.TabIndex = 4;
            this.lblAdministrationAbs.Text = "Administration";
            this.lblAdministrationAbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGestionAbsences
            // 
            this.lblGestionAbsences.BackColor = System.Drawing.Color.MediumPurple;
            this.lblGestionAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionAbsences.ForeColor = System.Drawing.Color.White;
            this.lblGestionAbsences.Location = new System.Drawing.Point(190, 397);
            this.lblGestionAbsences.Name = "lblGestionAbsences";
            this.lblGestionAbsences.Size = new System.Drawing.Size(303, 23);
            this.lblGestionAbsences.TabIndex = 5;
            this.lblGestionAbsences.Text = "Gestion des absences";
            this.lblGestionAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotifs
            // 
            this.lblMotifs.BackColor = System.Drawing.Color.Transparent;
            this.lblMotifs.Location = new System.Drawing.Point(37, 654);
            this.lblMotifs.Name = "lblMotifs";
            this.lblMotifs.Size = new System.Drawing.Size(100, 23);
            this.lblMotifs.TabIndex = 6;
            this.lblMotifs.Text = "Motif de l\'absence";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Location = new System.Drawing.Point(190, 499);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(100, 23);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Location = new System.Drawing.Point(37, 499);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 23);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom";
            // 
            // lblInfosAAbsences
            // 
            this.lblInfosAAbsences.BackColor = System.Drawing.Color.MediumPurple;
            this.lblInfosAAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosAAbsences.ForeColor = System.Drawing.Color.White;
            this.lblInfosAAbsences.Location = new System.Drawing.Point(37, 454);
            this.lblInfosAAbsences.Name = "lblInfosAAbsences";
            this.lblInfosAAbsences.Size = new System.Drawing.Size(283, 23);
            this.lblInfosAAbsences.TabIndex = 9;
            this.lblInfosAAbsences.Text = "Informations sur l\'absences";
            this.lblInfosAAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjouterAbs
            // 
            this.btnAjouterAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjouterAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterAbs.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAbs.Location = new System.Drawing.Point(402, 499);
            this.btnAjouterAbs.Name = "btnAjouterAbs";
            this.btnAjouterAbs.Size = new System.Drawing.Size(168, 42);
            this.btnAjouterAbs.TabIndex = 10;
            this.btnAjouterAbs.Text = "Ajouter";
            this.btnAjouterAbs.UseVisualStyleBackColor = false;
            this.btnAjouterAbs.Click += new System.EventHandler(this.btnAjouterAbs_Click);
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.BackColor = System.Drawing.Color.Blue;
            this.btnSupprimerAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAbs.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerAbs.Location = new System.Drawing.Point(402, 619);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(168, 42);
            this.btnSupprimerAbs.TabIndex = 11;
            this.btnSupprimerAbs.Text = "Supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = false;
            this.btnSupprimerAbs.Click += new System.EventHandler(this.btnSupprimerAbs_Click);
            // 
            // btnModifierAbs
            // 
            this.btnModifierAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModifierAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAbs.ForeColor = System.Drawing.Color.White;
            this.btnModifierAbs.Location = new System.Drawing.Point(402, 557);
            this.btnModifierAbs.Name = "btnModifierAbs";
            this.btnModifierAbs.Size = new System.Drawing.Size(168, 42);
            this.btnModifierAbs.TabIndex = 12;
            this.btnModifierAbs.Text = "Modifier";
            this.btnModifierAbs.UseVisualStyleBackColor = false;
            this.btnModifierAbs.Click += new System.EventHandler(this.btnModifierAbs_Click);
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(21, 711);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(140, 34);
            this.btnVider.TabIndex = 13;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(508, 711);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(140, 34);
            this.btnRetour.TabIndex = 14;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(40, 579);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(250, 20);
            this.dtpDebut.TabIndex = 15;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(40, 620);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(250, 20);
            this.dtpFin.TabIndex = 16;
            // 
            // cboMotifs
            // 
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(40, 670);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(250, 21);
            this.cboMotifs.TabIndex = 17;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(190, 515);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 18;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(40, 515);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 19;
            // 
            // frmGestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 772);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.cboMotifs);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnModifierAbs);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.btnAjouterAbs);
            this.Controls.Add(this.lblInfosAAbsences);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblMotifs);
            this.Controls.Add(this.lblGestionAbsences);
            this.Controls.Add(this.lblAdministrationAbs);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblListeAbsences);
            this.Controls.Add(this.dgvAbsences);
            this.Name = "frmGestionAbsences";
            this.Text = "Gestion des absence";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Label lblListeAbsences;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblAdministrationAbs;
        private System.Windows.Forms.Label lblGestionAbsences;
        private System.Windows.Forms.Label lblMotifs;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblInfosAAbsences;
        private System.Windows.Forms.Button btnAjouterAbs;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnModifierAbs;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}