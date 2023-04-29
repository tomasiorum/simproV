namespace SimproV
{
    partial class View
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
            label1 = new Label();
            label2 = new Label();
            nif = new TextBox();
            password = new TextBox();
            entrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 36);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "NIF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 36);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // nif
            // 
            nif.Location = new Point(85, 55);
            nif.Name = "nif";
            nif.Size = new Size(100, 23);
            nif.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(334, 55);
            password.Name = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 3;
            // 
            // entrar
            // 
            entrar.BackColor = SystemColors.ButtonFace;
            entrar.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            entrar.FlatAppearance.BorderSize = 2;
            entrar.Location = new Point(545, 54);
            entrar.Name = "entrar";
            entrar.Size = new Size(75, 23);
            entrar.TabIndex = 4;
            entrar.Text = "ENTRAR";
            entrar.UseVisualStyleBackColor = false;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(entrar);
            Controls.Add(password);
            Controls.Add(nif);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "View";
            Text = "View";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nif;
        private TextBox password;
        private Button entrar;
    }
}