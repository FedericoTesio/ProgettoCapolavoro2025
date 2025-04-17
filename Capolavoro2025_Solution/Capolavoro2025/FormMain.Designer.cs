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
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(2, 2);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(554, 192);
            this.DgvMagazzino.TabIndex = 0;
            // 
            // btnAggiungiPezzi
            // 
            this.btnAggiungiPezzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPezzi.Location = new System.Drawing.Point(2, 201);
            this.btnAggiungiPezzi.Name = "btnAggiungiPezzi";
            this.btnAggiungiPezzi.Size = new System.Drawing.Size(209, 37);
            this.btnAggiungiPezzi.TabIndex = 1;
            this.btnAggiungiPezzi.Text = "Aggiungi oggetti";
            this.btnAggiungiPezzi.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.btnAggiungiPezzi);
            this.Controls.Add(this.DgvMagazzino);
            this.Name = "FormMain";
            this.Text = "Magazzino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMagazzino;
        private System.Windows.Forms.Button btnAggiungiPezzi;
    }
}

