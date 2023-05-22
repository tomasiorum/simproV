
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
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtDocumentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaFaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListaFaturas
            // 
            this.dgListaFaturas.AllowUserToOrderColumns = true;
            this.dgListaFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIF,
            this.Nome,
            this.QtDocumentos});
            this.dgListaFaturas.Location = new System.Drawing.Point(43, 83);
            this.dgListaFaturas.Name = "dgListaFaturas";
            this.dgListaFaturas.RowHeadersWidth = 51;
            this.dgListaFaturas.RowTemplate.Height = 24;
            this.dgListaFaturas.Size = new System.Drawing.Size(770, 150);
            this.dgListaFaturas.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(393, 281);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(381, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Faturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NIF
            // 
            this.NIF.DataPropertyName = "NifComerciante";
            this.NIF.HeaderText = "Contribuiente";
            this.NIF.MinimumWidth = 6;
            this.NIF.Name = "NIF";
            this.NIF.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.Width = 125;
            // 
            // QtDocumentos
            // 
            this.QtDocumentos.DataPropertyName = "QtDocumentos";
            this.QtDocumentos.HeaderText = "Qt.Docs";
            this.QtDocumentos.MinimumWidth = 6;
            this.QtDocumentos.Name = "QtDocumentos";
            this.QtDocumentos.Width = 125;
            // 
            // FrmListaFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgListaFaturas);
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
    }
}