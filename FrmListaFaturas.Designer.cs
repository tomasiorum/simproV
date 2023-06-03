
namespace SimproV
{
    partial class FrmListaFaturas
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
            this.dgListaFaturas = new System.Windows.Forms.DataGridView();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtDocumentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceita = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaFaturas
            // 
            this.dgListaFaturas.AllowUserToDeleteRows = false;
            this.dgListaFaturas.AllowUserToOrderColumns = true;
            this.dgListaFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.Nome,
            this.QtDocumentos,
            this.Aceita});
            this.dgListaFaturas.Location = new System.Drawing.Point(32, 67);
            this.dgListaFaturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgListaFaturas.Name = "dgListaFaturas";
            this.dgListaFaturas.ReadOnly = true;
            this.dgListaFaturas.RowHeadersWidth = 51;
            this.dgListaFaturas.RowTemplate.Height = 24;
            this.dgListaFaturas.Size = new System.Drawing.Size(578, 122);
            this.dgListaFaturas.TabIndex = 0;
            this.dgListaFaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaFaturas_CellContentClick);
            // 
            // NIF
            // 
            this.NIF.DataPropertyName = "NifComerciante";
            this.NIF.HeaderText = "Contribuiente";
            this.NIF.MinimumWidth = 6;
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // QtDocumentos
            // 
            this.QtDocumentos.DataPropertyName = "QtDocumentos";
            this.QtDocumentos.HeaderText = "Qt.Docs";
            this.QtDocumentos.MinimumWidth = 6;
            this.QtDocumentos.Name = "QtDocumentos";
            this.QtDocumentos.ReadOnly = true;
            this.QtDocumentos.Width = 125;
            // 
            // Aceita
            // 
            this.Aceita.HeaderText = "Aceita";
            this.Aceita.MinimumWidth = 6;
            this.Aceita.Name = "Aceita";
            this.Aceita.ReadOnly = true;
            this.Aceita.Width = 125;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(295, 228);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 19);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(286, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(82, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Faturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmListaFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 366);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgListaFaturas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmListaFaturas";
            this.Text = "FrmListaFaturas";
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListaFaturas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtDocumentos;
        private System.Windows.Forms.DataGridViewButtonColumn Aceita;
    }
}