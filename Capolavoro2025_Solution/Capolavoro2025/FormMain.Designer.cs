namespace Capolavoro2025
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnCreaOrdine = new System.Windows.Forms.Button();
            this.btnElliminaOrdine = new System.Windows.Forms.Button();
            this.btnAggiungiPezzoOrdine = new System.Windows.Forms.Button();
            this.btnInviaDati = new System.Windows.Forms.Button();
            this.txtUtente = new System.Windows.Forms.TextBox();
            this.grbAccedi = new System.Windows.Forms.GroupBox();
            this.btnVisualizzaPassword = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUtente = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.grbAccedi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreaOrdine
            // 
            this.btnCreaOrdine.Location = new System.Drawing.Point(0, 0);
            this.btnCreaOrdine.Name = "btnCreaOrdine";
            this.btnCreaOrdine.Size = new System.Drawing.Size(75, 23);
            this.btnCreaOrdine.TabIndex = 0;
            // 
            // btnElliminaOrdine
            // 
            this.btnElliminaOrdine.Location = new System.Drawing.Point(0, 0);
            this.btnElliminaOrdine.Name = "btnElliminaOrdine";
            this.btnElliminaOrdine.Size = new System.Drawing.Size(75, 23);
            this.btnElliminaOrdine.TabIndex = 0;
            // 
            // btnAggiungiPezzoOrdine
            // 
            this.btnAggiungiPezzoOrdine.Location = new System.Drawing.Point(0, 0);
            this.btnAggiungiPezzoOrdine.Name = "btnAggiungiPezzoOrdine";
            this.btnAggiungiPezzoOrdine.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungiPezzoOrdine.TabIndex = 0;
            // 
            // btnInviaDati
            // 
            this.btnInviaDati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviaDati.Location = new System.Drawing.Point(46, 158);
            this.btnInviaDati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInviaDati.Name = "btnInviaDati";
            this.btnInviaDati.Size = new System.Drawing.Size(449, 41);
            this.btnInviaDati.TabIndex = 18;
            this.btnInviaDati.Text = "Log In";
            this.btnInviaDati.UseVisualStyleBackColor = true;
            this.btnInviaDati.Click += new System.EventHandler(this.btnInviaDati_Click);
            // 
            // txtUtente
            // 
            this.txtUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtente.Location = new System.Drawing.Point(173, 44);
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.Size = new System.Drawing.Size(322, 34);
            this.txtUtente.TabIndex = 19;
            // 
            // grbAccedi
            // 
            this.grbAccedi.Controls.Add(this.btnVisualizzaPassword);
            this.grbAccedi.Controls.Add(this.lblPassword);
            this.grbAccedi.Controls.Add(this.btnInviaDati);
            this.grbAccedi.Controls.Add(this.txtPassword);
            this.grbAccedi.Controls.Add(this.lblUtente);
            this.grbAccedi.Controls.Add(this.txtUtente);
            this.grbAccedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAccedi.Location = new System.Drawing.Point(106, 278);
            this.grbAccedi.Name = "grbAccedi";
            this.grbAccedi.Size = new System.Drawing.Size(520, 220);
            this.grbAccedi.TabIndex = 20;
            this.grbAccedi.TabStop = false;
            this.grbAccedi.Text = "Log in";
            // 
            // btnVisualizzaPassword
            // 
            this.btnVisualizzaPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaPassword.Location = new System.Drawing.Point(460, 103);
            this.btnVisualizzaPassword.Name = "btnVisualizzaPassword";
            this.btnVisualizzaPassword.Size = new System.Drawing.Size(35, 36);
            this.btnVisualizzaPassword.TabIndex = 21;
            this.btnVisualizzaPassword.Text = "👀";
            this.btnVisualizzaPassword.UseVisualStyleBackColor = true;
            this.btnVisualizzaPassword.Click += new System.EventHandler(this.btnVisualizzaPassword_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(41, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(126, 29);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(173, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 34);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUtente
            // 
            this.lblUtente.AutoSize = true;
            this.lblUtente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtente.Location = new System.Drawing.Point(41, 47);
            this.lblUtente.Name = "lblUtente";
            this.lblUtente.Size = new System.Drawing.Size(89, 29);
            this.lblUtente.TabIndex = 20;
            this.lblUtente.Text = "Utente:";
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbIcon.BackgroundImage")));
            this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbIcon.InitialImage = null;
            this.pcbIcon.Location = new System.Drawing.Point(106, 12);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(520, 260);
            this.pcbIcon.TabIndex = 21;
            this.pcbIcon.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 534);
            this.Controls.Add(this.pcbIcon);
            this.Controls.Add(this.grbAccedi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Magazzino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.grbAccedi.ResumeLayout(false);
            this.grbAccedi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreaOrdine;
        private System.Windows.Forms.Button btnElliminaOrdine;
        private System.Windows.Forms.Button btnAggiungiPezzoOrdine;
        private System.Windows.Forms.Button btnInviaDati;
        private System.Windows.Forms.TextBox txtUtente;
        private System.Windows.Forms.GroupBox grbAccedi;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUtente;
        private System.Windows.Forms.Button btnVisualizzaPassword;
        private System.Windows.Forms.PictureBox pcbIcon;
    }
}

