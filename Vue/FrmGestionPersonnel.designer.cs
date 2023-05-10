
namespace Mediatek.Vue
{
    partial class frmGestionPersonnel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonnel));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblGestionPersonnel = new System.Windows.Forms.Label();
            this.lblAdministrationAbs = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblListePersonnel = new System.Windows.Forms.Label();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.lblGestion = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(60, 510);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 39;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(213, 510);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 38;
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(60, 653);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(253, 21);
            this.cboServices.TabIndex = 37;
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbsences.ForeColor = System.Drawing.Color.White;
            this.btnAbsences.Location = new System.Drawing.Point(440, 692);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(214, 34);
            this.btnAbsences.TabIndex = 34;
            this.btnAbsences.Text = "Gérer les absences";
            this.btnAbsences.UseVisualStyleBackColor = false;
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.White;
            this.btnVider.Location = new System.Drawing.Point(32, 692);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(140, 34);
            this.btnVider.TabIndex = 33;
            this.btnVider.Text = "Réinitialiser";
            this.btnVider.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(425, 564);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(168, 42);
            this.btnModifier.TabIndex = 32;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.BackColor = System.Drawing.Color.Blue;
            this.btnSupprimerAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAbs.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerAbs.Location = new System.Drawing.Point(425, 629);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(168, 42);
            this.btnSupprimerAbs.TabIndex = 31;
            this.btnSupprimerAbs.Text = "Supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(425, 497);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(168, 42);
            this.btnAjouter.TabIndex = 30;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.BackColor = System.Drawing.Color.MediumPurple;
            this.lblPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblPersonnel.Location = new System.Drawing.Point(30, 452);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(283, 23);
            this.lblPersonnel.TabIndex = 29;
            this.lblPersonnel.Text = "Informations personnelles";
            this.lblPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Location = new System.Drawing.Point(57, 493);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(100, 14);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Location = new System.Drawing.Point(210, 493);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(100, 12);
            this.lblPrenom.TabIndex = 27;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblService
            // 
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Location = new System.Drawing.Point(60, 639);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(100, 11);
            this.lblService.TabIndex = 26;
            this.lblService.Text = "Service";
            // 
            // lblGestionPersonnel
            // 
            this.lblGestionPersonnel.BackColor = System.Drawing.Color.MediumPurple;
            this.lblGestionPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonnel.ForeColor = System.Drawing.Color.White;
            this.lblGestionPersonnel.Location = new System.Drawing.Point(190, 415);
            this.lblGestionPersonnel.Name = "lblGestionPersonnel";
            this.lblGestionPersonnel.Size = new System.Drawing.Size(303, 23);
            this.lblGestionPersonnel.TabIndex = 25;
            this.lblGestionPersonnel.Text = "Gestion du personnel";
            this.lblGestionPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdministrationAbs
            // 
            this.lblAdministrationAbs.BackColor = System.Drawing.Color.MediumPurple;
            this.lblAdministrationAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrationAbs.ForeColor = System.Drawing.Color.White;
            this.lblAdministrationAbs.Location = new System.Drawing.Point(371, 452);
            this.lblAdministrationAbs.Name = "lblAdministrationAbs";
            this.lblAdministrationAbs.Size = new System.Drawing.Size(283, 23);
            this.lblAdministrationAbs.TabIndex = 24;
            this.lblAdministrationAbs.Text = "Administration";
            this.lblAdministrationAbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTel
            // 
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Location = new System.Drawing.Point(57, 550);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 11);
            this.lblTel.TabIndex = 23;
            this.lblTel.Text = "Tel";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Location = new System.Drawing.Point(60, 595);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 11);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "Mail";
            // 
            // lblListePersonnel
            // 
            this.lblListePersonnel.BackColor = System.Drawing.Color.MediumPurple;
            this.lblListePersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePersonnel.ForeColor = System.Drawing.Color.White;
            this.lblListePersonnel.Location = new System.Drawing.Point(190, 79);
            this.lblListePersonnel.Name = "lblListePersonnel";
            this.lblListePersonnel.Size = new System.Drawing.Size(303, 23);
            this.lblListePersonnel.TabIndex = 21;
            this.lblListePersonnel.Text = "Liste du personnel";
            this.lblListePersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPersonnel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPersonnel.EnableHeadersVisualStyles = false;
            this.dgvPersonnel.Location = new System.Drawing.Point(32, 95);
            this.dgvPersonnel.Name = "dgvPersonnel";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgvPersonnel.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonnel.Size = new System.Drawing.Size(622, 284);
            this.dgvPersonnel.TabIndex = 60;
            // 
            // lblGestion
            // 
            this.lblGestion.BackColor = System.Drawing.Color.Transparent;
            this.lblGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.White;
            this.lblGestion.Location = new System.Drawing.Point(18, 2);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(215, 20);
            this.lblGestion.TabIndex = 40;
            this.lblGestion.Text = "Gestion du personnel";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(60, 564);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(253, 20);
            this.txtTel.TabIndex = 41;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(63, 609);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(250, 20);
            this.txtMail.TabIndex = 42;
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(685, 757);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimerAbs);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblGestionPersonnel);
            this.Controls.Add(this.lblAdministrationAbs);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblListePersonnel);
            this.Controls.Add(this.dgvPersonnel);
            this.Name = "frmGestionPersonnel";
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblGestionPersonnel;
        private System.Windows.Forms.Label lblAdministrationAbs;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblListePersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
    }
}