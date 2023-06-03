
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
            this.Atividade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Aceita = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.Atividade,
            this.Aceita});
            this.dgListaFaturas.Location = new System.Drawing.Point(66, 92);
            this.dgListaFaturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgListaFaturas.Name = "dgListaFaturas";
            this.dgListaFaturas.RowHeadersWidth = 51;
            this.dgListaFaturas.RowTemplate.Height = 24;
            this.dgListaFaturas.Size = new System.Drawing.Size(948, 101);
            this.dgListaFaturas.TabIndex = 0;
            this.dgListaFaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListaFaturas_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(472, 246);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 55);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(418, 45);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Faturas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // Atividade
            // 
            this.Atividade.AutoComplete = false;
            this.Atividade.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Atividade.HeaderText = "Ativividade";
            this.Atividade.Items.AddRange(new object[] {
            "Cabeleireiros",
            "Oficinas",
            "Restauração",
            "Saùde"});
            this.Atividade.Name = "Atividade";
            this.Atividade.Sorted = true;
            this.Atividade.ToolTipText = "Atividade";
            // 
            // Aceita
            // 
            this.Aceita.HeaderText = "Aceita";
            this.Aceita.MinimumWidth = 6;
            this.Aceita.Name = "Aceita";
            this.Aceita.Width = 125;
            // 
            // FrmListaFaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 366);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgListaFaturas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListaFaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SimproV";
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Atividade;
        private System.Windows.Forms.DataGridViewButtonColumn Aceita;
    }
}