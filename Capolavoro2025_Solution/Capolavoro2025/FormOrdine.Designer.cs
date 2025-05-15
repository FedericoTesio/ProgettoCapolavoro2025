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
            ((System.ComponentModel.ISupportInitialize)(this.DgvMagazzino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdine)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvMagazzino
            // 
            this.DgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMagazzino.Location = new System.Drawing.Point(11, 10);
            this.DgvMagazzino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvMagazzino.Name = "DgvMagazzino";
            this.DgvMagazzino.RowHeadersWidth = 51;
            this.DgvMagazzino.RowTemplate.Height = 24;
            this.DgvMagazzino.Size = new System.Drawing.Size(720, 122);
            this.DgvMagazzino.TabIndex = 0;
            // 
            // DgvOrdine
            // 
            this.DgvOrdine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdine.Location = new System.Drawing.Point(11, 188);
            this.DgvOrdine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvOrdine.Name = "DgvOrdine";
            this.DgvOrdine.RowHeadersWidth = 51;
            this.DgvOrdine.RowTemplate.Height = 24;
            this.DgvOrdine.Size = new System.Drawing.Size(720, 122);
            this.DgvOrdine.TabIndex = 1;
            // 
            // btnCercaPezzo
            // 
            this.btnCercaPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaPezzo.Location = new System.Drawing.Point(213, 143);
            this.btnCercaPezzo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCercaPezzo.Name = "btnCercaPezzo";
            this.btnCercaPezzo.Size = new System.Drawing.Size(157, 30);
            this.btnCercaPezzo.TabIndex = 32;
            this.btnCercaPezzo.Text = "Cerca pezzo";
            this.btnCercaPezzo.UseVisualStyleBackColor = true;
            this.btnCercaPezzo.Click += new System.EventHandler(this.btnCercaPezzo_Click);
            // 
            // btnAggiungiPezzo
            // 
            this.btnAggiungiPezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiPezzo.Location = new System.Drawing.Point(165, 321);
            this.btnAggiungiPezzo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAggiungiPezzo.Name = "btnAggiungiPezzo";
            this.btnAggiungiPezzo.Size = new System.Drawing.Size(157, 30);
            this.btnAggiungiPezzo.TabIndex = 33;
            this.btnAggiungiPezzo.Text = "Aggiungi pezzo all\'ordine";
            this.btnAggiungiPezzo.UseVisualStyleBackColor = true;
            this.btnAggiungiPezzo.Click += new System.EventHandler(this.btnAggiungiPezzo_Click);
            // 
            // btnRimuoviPezzoOrdine
            // 
            this.btnRimuoviPezzoOrdine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRimuoviPezzoOrdine.Location = new System.Drawing.Point(349, 321);
            this.btnRimuoviPezzoOrdine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRimuoviPezzoOrdine.Name = "btnRimuoviPezzoOrdine";
            this.btnRimuoviPezzoOrdine.Size = new System.Drawing.Size(157, 30);
            this.btnRimuoviPezzoOrdine.TabIndex = 34;
            this.btnRimuoviPezzoOrdine.Text = "Rimuovi pezzo dall\'ordine";
            this.btnRimuoviPezzoOrdine.UseVisualStyleBackColor = true;
            // 
            // FormOrdine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 405);
            this.Controls.Add(this.btnRimuoviPezzoOrdine);
            this.Controls.Add(this.btnAggiungiPezzo);
            this.Controls.Add(this.btnCercaPezzo);
            this.Controls.Add(this.DgvOrdine);
            this.Controls.Add(this.DgvMagazzino);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}