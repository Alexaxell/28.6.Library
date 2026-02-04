namespace _28._6.Library.Winform
{
    partial class FormAddDocente
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
            label3 = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            txtTitoloDiStudio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 59);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 137);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 228);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Titolo di studio";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(183, 59);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(183, 137);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(100, 23);
            txtCognome.TabIndex = 4;
            // 
            // txtTitoloDiStudio
            // 
            txtTitoloDiStudio.Location = new Point(183, 228);
            txtTitoloDiStudio.Name = "txtTitoloDiStudio";
            txtTitoloDiStudio.Size = new Size(100, 23);
            txtTitoloDiStudio.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(544, 59);
            button1.Name = "button1";
            button1.Size = new Size(167, 133);
            button1.TabIndex = 6;
            button1.Text = "AddDocente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAddDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtTitoloDiStudio);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddDocente";
            Text = "FormAddDocente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtTitoloDiStudio;
        private Button button1;
    }
}