namespace Capolavoro2025
{
    partial class FormOrdine
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
            this.DgvMagazzino = new System.Windows.Forms.DataGridView();
            this.DgvOrdine = new System.Windows.Forms.DataGridView();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
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
            this.btnCercaPezzo = new System.Windows.Forms.Button();
            this.btnAggiungiPezzo = new System.Windows.Forms.Button();
            this.btnRimuoviPezzoOrdine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(12, 12);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(240, 150);
            this.DgvMagazzino.TabIndex = 0;
            // 
            // DgvOrdine
            // 
            this.DgvOrdine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdine.Location = new System.Drawing.Point(320, 12);
            this.DgvOrdine.Name = "DgvOrdine";
            this.DgvOrdine.RowHeadersWidth = 51;
            this.DgvOrdine.RowTemplate.Height = 24;
            this.DgvOrdine.Size = new System.Drawing.Size(240, 150);
            this.DgvOrdine.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(63, 259);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(132, 22);
            this.txtPeso.TabIndex = 31;
            // 
            // lblPeso
            // 
            this.lblPeso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(13, 262);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 16);
            this.lblPeso.TabIndex = 30;
            this.lblPeso.Text = "Peso:";
            // 
            // txtDimensione
            // 
            this.txtDimensione.Location = new System.Drawing.Point(96, 231);
            this.txtDimensione.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimensione.Name = "txtDimensione";
            this.txtDimensione.Size = new System.Drawing.Size(132, 22);
            this.txtDimensione.TabIndex = 29;
            // 
            // nudQuantità
            // 
            this.nudQuantità.Location = new System.Drawing.Point(91, 315);
            this.nudQuantità.Margin = new System.Windows.Forms.Padding(4);
            this.nudQuantità.Name = "nudQuantità";
            this.nudQuantità.Size = new System.Drawing.Size(160, 22);
            this.nudQuantità.TabIndex = 28;
            // 
            // nudCosto
            // 
            this.nudCosto.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.nudCosto.Location = new System.Drawing.Point(76, 287);
            this.nudCosto.Margin = new System.Windows.Forms.Padding(4);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(160, 22);
            this.nudCosto.TabIndex = 27;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(76, 343);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(132, 22);
            this.txtCodice.TabIndex = 26;
            // 
            // txtMateriale
            // 
            this.txtMateriale.Location = new System.Drawing.Point(87, 203);
            this.txtMateriale.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateriale.Name = "txtMateriale";
            this.txtMateriale.Size = new System.Drawing.Size(132, 22);
            this.txtMateriale.TabIndex = 25;
            // 
            // txtOggetto
            // 
            this.txtOggetto.Location = new System.Drawing.Point(87, 175);
            this.txtOggetto.Margin = new System.Windows.Forms.Padding(4);
            this.txtOggetto.Name = "txtOggetto";
            this.txtOggetto.Size = new System.Drawing.Size(132, 22);
            this.txtOggetto.TabIndex = 24;
            // 
            // lblCodice
            // 
            this.lblCodice.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(13, 349);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(53, 16);
            this.lblCodice.TabIndex = 23;
            this.lblCodice.Text = "Codice:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(13, 320);
            this.lblQuantita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(59, 16);
            this.lblQuantita.TabIndex = 22;
            this.lblQuantita.Text = "Quantità:";
            // 
            // lblCosto
            // 
            this.lblCosto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(13, 291);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(45, 16);
            this.lblCosto.TabIndex = 21;
            this.lblCosto.Text = "Costo:";
            // 
            // lblDimensione
            // 
            this.lblDimensione.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDimensione.AutoSize = true;
            this.lblDimensione.Location = new System.Drawing.Point(13, 233);
            this.lblDimensione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimensione.Name = "lblDimensione";
            this.lblDimensione.Size = new System.Drawing.Size(82, 16);
            this.lblDimensione.TabIndex = 20;
            this.lblDimensione.Text = "Dimensione:";
            // 
            // lblMateriale
            // 
            this.lblMateriale.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMateriale.AutoSize = true;
            this.lblMateriale.Location = new System.Drawing.Point(13, 204);
            this.lblMateriale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriale.Name = "lblMateriale";
            this.lblMateriale.Size = new System.Drawing.Size(66, 16);
            this.lblMateriale.TabIndex = 19;
            this.lblMateriale.Text = "Materiale:";
            // 
            // lblOggetto
            // 
            this.lblOggetto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblOggetto.AutoSize = true;
            this.lblOggetto.Location = new System.Drawing.Point(13, 175);
            this.lblOggetto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOggetto.Name = "lblOggetto";
            this.lblOggetto.Size = new System.Drawing.Size(58, 16);
            this.lblOggetto.TabIndex = 18;
            this.lblOggetto.Text = "Oggetto:";
            // 
            // btnCercaPezzo
            // 
            this.btnCercaPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaPezzo.Location = new System.Drawing.Point(10, 383);
            this.btnCercaPezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCercaPezzo.Name = "btnCercaPezzo";
            this.btnCercaPezzo.Size = new System.Drawing.Size(209, 37);
            this.btnCercaPezzo.TabIndex = 32;
            this.btnCercaPezzo.Text = "Cerca pezzo";
            this.btnCercaPezzo.UseVisualStyleBackColor = true;
            this.btnCercaPezzo.Click += new System.EventHandler(this.btnCercaPezzo_Click);
            // 
            // btnAggiungiPezzo
            // 
            this.btnAggiungiPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPezzo.Location = new System.Drawing.Point(320, 183);
            this.btnAggiungiPezzo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAggiungiPezzo.Name = "btnAggiungiPezzo";
            this.btnAggiungiPezzo.Size = new System.Drawing.Size(209, 37);
            this.btnAggiungiPezzo.TabIndex = 33;
            this.btnAggiungiPezzo.Text = "Aggiungi pezzo all\'ordine";
            this.btnAggiungiPezzo.UseVisualStyleBackColor = true;
            this.btnAggiungiPezzo.Click += new System.EventHandler(this.btnAggiungiPezzo_Click);
            // 
            // btnRimuoviPezzoOrdine
            // 
            this.btnRimuoviPezzoOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviPezzoOrdine.Location = new System.Drawing.Point(320, 233);
            this.btnRimuoviPezzoOrdine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRimuoviPezzoOrdine.Name = "btnRimuoviPezzoOrdine";
            this.btnRimuoviPezzoOrdine.Size = new System.Drawing.Size(209, 37);
            this.btnRimuoviPezzoOrdine.TabIndex = 34;
            this.btnRimuoviPezzoOrdine.Text = "Rimuovi pezzo dall\'ordine";
            this.btnRimuoviPezzoOrdine.UseVisualStyleBackColor = true;
            // 
            // FormOrdine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRimuoviPezzoOrdine);
            this.Controls.Add(this.btnAggiungiPezzo);
            this.Controls.Add(this.btnCercaPezzo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
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
            this.Controls.Add(this.DgvOrdine);
            this.Controls.Add(this.DgvMagazzino);
            this.Name = "FormOrdine";
            this.Text = "Ordine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdine_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrdine_FormClosed);
            this.Load += new System.EventHandler(this.FormOrdine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantità)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMagazzino;
        private System.Windows.Forms.DataGridView DgvOrdine;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
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
        private System.Windows.Forms.Button btnCercaPezzo;
        private System.Windows.Forms.Button btnAggiungiPezzo;
        private System.Windows.Forms.Button btnRimuoviPezzoOrdine;
    }
}