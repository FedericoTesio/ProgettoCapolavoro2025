namespace Capolavoro2025
{
    partial class FormMagazzino
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
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.btnCercaPezzo = new System.Windows.Forms.Button();
            this.btnRimuoviOggetto = new System.Windows.Forms.Button();
            this.txtDimensione = new System.Windows.Forms.TextBox();
            this.nudQuantità = new System.Windows.Forms.NumericUpDown();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtMateriale = new System.Windows.Forms.TextBox();
            this.txtOggetto = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblDimensione = new System.Windows.Forms.Label();
            this.lblMateriale = new System.Windows.Forms.Label();
            this.lblOggetto = new System.Windows.Forms.Label();
            this.btnAggiungiPezzi = new System.Windows.Forms.Button();
            this.DgvMagazzino = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(63, 295);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(132, 22);
            this.txtPeso.TabIndex = 36;
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(13, 298);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 35;
            this.lblPeso.Text = "Peso:";
            // 
            // btnCercaPezzo
            // 
            this.btnCercaPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaPezzo.Location = new System.Drawing.Point(358, 327);
            this.btnCercaPezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercaPezzo.Name = "btnCercaPezzo";
            this.btnCercaPezzo.Size = new System.Drawing.Size(209, 37);
            this.btnCercaPezzo.TabIndex = 34;
            this.btnCercaPezzo.Text = "Cerca pezzo";
            this.btnCercaPezzo.UseVisualStyleBackColor = true;
            this.btnCercaPezzo.Click += new System.EventHandler(this.btnCercaPezzo_Click);
            // 
            // btnRimuoviOggetto
            // 
            this.btnRimuoviOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviOggetto.Location = new System.Drawing.Point(358, 269);
            this.btnRimuoviOggetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRimuoviOggetto.Name = "btnRimuoviOggetto";
            this.btnRimuoviOggetto.Size = new System.Drawing.Size(209, 37);
            this.btnRimuoviOggetto.TabIndex = 33;
            this.btnRimuoviOggetto.Text = "Rimuovi pezzi";
            this.btnRimuoviOggetto.UseVisualStyleBackColor = true;
            this.btnRimuoviOggetto.Click += new System.EventHandler(this.btnRimuoviOggetto_Click);
            // 
            // txtDimensione
            // 
            this.txtDimensione.Location = new System.Drawing.Point(96, 267);
            this.txtDimensione.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimensione.Name = "txtDimensione";
            this.txtDimensione.Size = new System.Drawing.Size(132, 22);
            this.txtDimensione.TabIndex = 32;
            // 
            // nudQuantità
            // 
            this.nudQuantità.Location = new System.Drawing.Point(91, 351);
            this.nudQuantità.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantità.Name = "nudQuantità";
            this.nudQuantità.Size = new System.Drawing.Size(160, 22);
            this.nudQuantità.TabIndex = 31;
            // 
            // nudCosto
            // 
            this.nudCosto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCosto.Location = new System.Drawing.Point(76, 323);
            this.nudCosto.Margin = new System.Windows.Forms.Padding(4);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(160, 22);
            this.nudCosto.TabIndex = 30;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(76, 379);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(132, 22);
            this.txtCodice.TabIndex = 29;
            // 
            // txtMateriale
            // 
            this.txtMateriale.Location = new System.Drawing.Point(87, 239);
            this.txtMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateriale.Name = "txtMateriale";
            this.txtMateriale.Size = new System.Drawing.Size(132, 22);
            this.txtMateriale.TabIndex = 28;
            // 
            // txtOggetto
            // 
            this.txtOggetto.Location = new System.Drawing.Point(87, 211);
            this.txtOggetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(132, 22);
            this.txtOggetto.TabIndex = 27;
            // 
            // lblCodice
            // 
            this.lblCodice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(13, 385);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(53, 16);
            this.lblCodice.TabIndex = 26;
            this.lblCodice.Text = "Codice:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(13, 356);
            this.lblQuantita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(59, 16);
            this.lblQuantita.TabIndex = 25;
            this.lblQuantita.Text = "Quantità:";
            // 
            // lblCosto
            // 
            this.lblCosto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(13, 327);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 16);
            this.lblCosto.TabIndex = 24;
            this.lblCosto.Text = "Costo:";
            // 
            // lblDimensione
            // 
            this.lblDimensione.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDimensione.AutoSize = true;
            this.lblDimensione.Location = new System.Drawing.Point(13, 269);
            this.lblDimensione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimensione.Name = "lblDimensione";
            this.lblDimensione.Size = new System.Drawing.Size(82, 16);
            this.lblDimensione.TabIndex = 23;
            this.lblDimensione.Text = "Dimensione:";
            // 
            // lblMateriale
            // 
            this.lblMateriale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMateriale.AutoSize = true;
            this.lblMateriale.Location = new System.Drawing.Point(13, 240);
            this.lblMateriale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriale.Name = "lblMateriale";
            this.lblMateriale.Size = new System.Drawing.Size(66, 16);
            this.lblMateriale.TabIndex = 22;
            this.lblMateriale.Text = "Materiale:";
            // 
            // lblOggetto
            // 
            this.lblOggetto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblOggetto.AutoSize = true;
            this.lblOggetto.Location = new System.Drawing.Point(13, 211);
            this.lblOggetto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOggetto.Name = "lblOggetto";
            this.lblOggetto.Size = new System.Drawing.Size(58, 16);
            this.lblOggetto.TabIndex = 21;
            this.lblOggetto.Text = "Oggetto:";
            // 
            // btnAggiungiPezzi
            // 
            this.btnAggiungiPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPezzi.Location = new System.Drawing.Point(358, 211);
            this.btnAggiungiPezzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggiungiPezzi.Name = "btnAggiungiPezzi";
            this.btnAggiungiPezzi.Size = new System.Drawing.Size(209, 37);
            this.btnAggiungiPezzi.TabIndex = 20;
            this.btnAggiungiPezzi.Text = "Aggiungi pezzi";
            this.btnAggiungiPezzi.UseVisualStyleBackColor = true;
            this.btnAggiungiPezzi.Click += new System.EventHandler(this.btnAggiungiPezzi_Click);
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(12, 11);
            this.DgvMagazzino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(555, 192);
            this.DgvMagazzino.TabIndex = 19;
            // 
            // FormMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 412);
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
            this.Name = "FormMagazzino";
            this.Text = "FormMagazzino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMagazzino_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMagazzino_FormClosed);
            this.Load += new System.EventHandler(this.FormMagazzino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Button btnCercaPezzo;
        private System.Windows.Forms.Button btnRimuoviOggetto;
        private System.Windows.Forms.TextBox txtDimensione;
        private System.Windows.Forms.NumericUpDown nudQuantità;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtMateriale;
        private System.Windows.Forms.TextBox txtOggetto;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblDimensione;
        private System.Windows.Forms.Label lblMateriale;
        private System.Windows.Forms.Label lblOggetto;
        private System.Windows.Forms.Button btnAggiungiPezzi;
        private System.Windows.Forms.DataGridView DgvMagazzino;
    }
}