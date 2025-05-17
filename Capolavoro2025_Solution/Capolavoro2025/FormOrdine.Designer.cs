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
            this.btnCercaPezzo = new System.Windows.Forms.Button();
            this.btnAggiungiPezzo = new System.Windows.Forms.Button();
            this.btnRimuoviPezzoOrdine = new System.Windows.Forms.Button();
            this.btnInviaOrdine = new System.Windows.Forms.Button();
            this.btnEliminaOrdine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdine)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(15, 12);
            this.DgvMagazzino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(960, 150);
            this.DgvMagazzino.TabIndex = 0;
            // 
            // DgvOrdine
            // 
            this.DgvOrdine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdine.Location = new System.Drawing.Point(15, 231);
            this.DgvOrdine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvOrdine.Name = "DgvOrdine";
            this.DgvOrdine.RowHeadersWidth = 51;
            this.DgvOrdine.RowTemplate.Height = 24;
            this.DgvOrdine.Size = new System.Drawing.Size(960, 150);
            this.DgvOrdine.TabIndex = 1;
            // 
            // btnCercaPezzo
            // 
            this.btnCercaPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaPezzo.Location = new System.Drawing.Point(15, 179);
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
            this.btnAggiungiPezzo.Location = new System.Drawing.Point(15, 395);
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
            this.btnRimuoviPezzoOrdine.Location = new System.Drawing.Point(230, 395);
            this.btnRimuoviPezzoOrdine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRimuoviPezzoOrdine.Name = "btnRimuoviPezzoOrdine";
            this.btnRimuoviPezzoOrdine.Size = new System.Drawing.Size(209, 37);
            this.btnRimuoviPezzoOrdine.TabIndex = 34;
            this.btnRimuoviPezzoOrdine.Text = "Rimuovi pezzo dall\'ordine";
            this.btnRimuoviPezzoOrdine.UseVisualStyleBackColor = true;
            // 
            // btnInviaOrdine
            // 
            this.btnInviaOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInviaOrdine.Location = new System.Drawing.Point(445, 395);
            this.btnInviaOrdine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInviaOrdine.Name = "btnInviaOrdine";
            this.btnInviaOrdine.Size = new System.Drawing.Size(209, 37);
            this.btnInviaOrdine.TabIndex = 35;
            this.btnInviaOrdine.Text = "Invia ordine";
            this.btnInviaOrdine.UseVisualStyleBackColor = true;
            this.btnInviaOrdine.Click += new System.EventHandler(this.btnInviaOrdine_Click);
            // 
            // btnEliminaOrdine
            // 
            this.btnEliminaOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaOrdine.Location = new System.Drawing.Point(660, 395);
            this.btnEliminaOrdine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminaOrdine.Name = "btnEliminaOrdine";
            this.btnEliminaOrdine.Size = new System.Drawing.Size(209, 37);
            this.btnEliminaOrdine.TabIndex = 36;
            this.btnEliminaOrdine.Text = "Elimina ordine";
            this.btnEliminaOrdine.UseVisualStyleBackColor = true;
            this.btnEliminaOrdine.Click += new System.EventHandler(this.btnEliminaOrdine_Click);
            // 
            // FormOrdine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 498);
            this.Controls.Add(this.btnEliminaOrdine);
            this.Controls.Add(this.btnInviaOrdine);
            this.Controls.Add(this.btnRimuoviPezzoOrdine);
            this.Controls.Add(this.btnAggiungiPezzo);
            this.Controls.Add(this.btnCercaPezzo);
            this.Controls.Add(this.DgvOrdine);
            this.Controls.Add(this.DgvMagazzino);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrdine";
            this.Text = "Ordine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrdine_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrdine_FormClosed);
            this.Load += new System.EventHandler(this.FormOrdine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMagazzino;
        private System.Windows.Forms.DataGridView DgvOrdine;
        private System.Windows.Forms.Button btnCercaPezzo;
        private System.Windows.Forms.Button btnAggiungiPezzo;
        private System.Windows.Forms.Button btnRimuoviPezzoOrdine;
        private System.Windows.Forms.Button btnInviaOrdine;
        private System.Windows.Forms.Button btnEliminaOrdine;
    }
}