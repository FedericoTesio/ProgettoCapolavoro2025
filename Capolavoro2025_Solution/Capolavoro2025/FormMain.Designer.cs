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
            this.DgvMagazzino = new System.Windows.Forms.DataGridView();
            this.btnAggiungiPezzi = new System.Windows.Forms.Button();
            this.lblOggetto = new System.Windows.Forms.Label();
            this.lblMateriale = new System.Windows.Forms.Label();
            this.lblDimensione = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.txtMateriale = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.nudQuantità = new System.Windows.Forms.NumericUpDown();
            this.txtDimensione = new System.Windows.Forms.TextBox();
            this.btnRimuoviOggetto = new System.Windows.Forms.Button();
            this.btnCercaPezzo = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(3, 2);
            this.DgvMagazzino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(555, 192);
            this.DgvMagazzino.TabIndex = 0;
            // 
            // btnAggiungiPezzi
            // 
            this.btnAggiungiPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPezzi.Location = new System.Drawing.Point(7, 406);
            this.btnAggiungiPezzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggiungiPezzi.Name = "btnAggiungiPezzi";
            this.btnAggiungiPezzi.Size = new System.Drawing.Size(209, 37);
            this.btnAggiungiPezzi.TabIndex = 1;
            this.btnAggiungiPezzi.Text = "Aggiungi pezzi";
            this.btnAggiungiPezzi.UseVisualStyleBackColor = true;
            this.btnAggiungiPezzi.Click += new System.EventHandler(this.btnAggiungiPezzi_Click);
            // 
            // lblOggetto
            // 
            this.lblOggetto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblOggetto.AutoSize = true;
            this.lblOggetto.Location = new System.Drawing.Point(17, 202);
            this.lblOggetto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOggetto.Name = "lblOggetto";
            this.lblOggetto.Size = new System.Drawing.Size(58, 16);
            this.lblOggetto.TabIndex = 2;
            this.lblOggetto.Text = "Oggetto:";
            // 
            // lblMateriale
            // 
            this.lblMateriale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMateriale.AutoSize = true;
            this.lblMateriale.Location = new System.Drawing.Point(17, 231);
            this.lblMateriale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriale.Name = "lblMateriale";
            this.lblMateriale.Size = new System.Drawing.Size(66, 16);
            this.lblMateriale.TabIndex = 3;
            this.lblMateriale.Text = "Materiale:";
            // 
            // lblDimensione
            // 
            this.lblDimensione.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDimensione.AutoSize = true;
            this.lblDimensione.Location = new System.Drawing.Point(17, 260);
            this.lblDimensione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimensione.Name = "lblDimensione";
            this.lblDimensione.Size = new System.Drawing.Size(82, 16);
            this.lblDimensione.TabIndex = 4;
            this.lblDimensione.Text = "Dimensione:";
            // 
            // lblCosto
            // 
            this.lblCosto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(17, 318);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 16);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(17, 347);
            this.lblQuantita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(59, 16);
            this.lblQuantita.TabIndex = 6;
            this.lblQuantita.Text = "Quantità:";
            // 
            // lblCodice
            // 
            this.lblCodice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(17, 376);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(53, 16);
            this.lblCodice.TabIndex = 7;
            this.lblCodice.Text = "Codice:";
            // 
            // txtOggetto
            // 
            this.txtOggetto.Location = new System.Drawing.Point(91, 202);
            this.txtOggetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(132, 22);
            this.txtOggetto.TabIndex = 8;
            // 
            // txtMateriale
            // 
            this.txtMateriale.Location = new System.Drawing.Point(91, 230);
            this.txtMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateriale.Name = "txtMateriale";
            this.txtMateriale.Size = new System.Drawing.Size(132, 22);
            this.txtMateriale.TabIndex = 9;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(80, 370);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(132, 22);
            this.txtCodice.TabIndex = 10;
            // 
            // nudCosto
            // 
            this.nudCosto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCosto.Location = new System.Drawing.Point(80, 314);
            this.nudCosto.Margin = new System.Windows.Forms.Padding(4);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(160, 22);
            this.nudCosto.TabIndex = 11;
            // 
            // nudQuantità
            // 
            this.nudQuantità.Location = new System.Drawing.Point(95, 342);
            this.nudQuantità.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantità.Name = "nudQuantità";
            this.nudQuantità.Size = new System.Drawing.Size(160, 22);
            this.nudQuantità.TabIndex = 12;
            // 
            // txtDimensione
            // 
            this.txtDimensione.Location = new System.Drawing.Point(100, 258);
            this.txtDimensione.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimensione.Name = "txtDimensione";
            this.txtDimensione.Size = new System.Drawing.Size(132, 22);
            this.txtDimensione.TabIndex = 13;
            // 
            // btnRimuoviOggetto
            // 
            this.btnRimuoviOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviOggetto.Location = new System.Drawing.Point(7, 449);
            this.btnRimuoviOggetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRimuoviOggetto.Name = "btnRimuoviOggetto";
            this.btnRimuoviOggetto.Size = new System.Drawing.Size(209, 37);
            this.btnRimuoviOggetto.TabIndex = 14;
            this.btnRimuoviOggetto.Text = "Rimuovi pezzi";
            this.btnRimuoviOggetto.UseVisualStyleBackColor = true;
            this.btnRimuoviOggetto.Click += new System.EventHandler(this.btnRimuoviOggetto_Click);
            // 
            // btnCercaPezzo
            // 
            this.btnCercaPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaPezzo.Location = new System.Drawing.Point(321, 208);
            this.btnCercaPezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercaPezzo.Name = "btnCercaPezzo";
            this.btnCercaPezzo.Size = new System.Drawing.Size(209, 37);
            this.btnCercaPezzo.TabIndex = 15;
            this.btnCercaPezzo.Text = "Cerca pezzo";
            this.btnCercaPezzo.UseVisualStyleBackColor = true;
            this.btnCercaPezzo.Click += new System.EventHandler(this.btnCercaPezzo_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(67, 286);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(132, 22);
            this.txtPeso.TabIndex = 17;
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(17, 289);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 492);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCercaPezzo);
            this.Controls.Add(this.btnRimuoviOggetto);
            this.Controls.Add(this.txtDimensione);
            this.Controls.Add(this.nudQuantità);
            this.Controls.Add(this.nudCosto);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.txtMateriale);
            this.Controls.Add(this.txtOggetto);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDimensione);
            this.Controls.Add(this.lblMateriale);
            this.Controls.Add(this.lblOggetto);
            this.Controls.Add(this.btnAggiungiPezzi);
            this.Controls.Add(this.DgvMagazzino);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Magazzino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMagazzino;
        private System.Windows.Forms.Button btnAggiungiPezzi;
        private System.Windows.Forms.Label lblOggetto;
        private System.Windows.Forms.Label lblMateriale;
        private System.Windows.Forms.Label lblDimensione;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.Label lblCodice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.TextBox txtMateriale;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.NumericUpDown nudQuantità;
        private System.Windows.Forms.TextBox txtDimensione;
        private System.Windows.Forms.Button btnRimuoviOggetto;
        private System.Windows.Forms.Button btnCercaPezzo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}

