namespace _28._6.Library.Winform
{
    partial class FormAddAula
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
            txtCapienza = new TextBox();
            txtNome = new TextBox();
            cbxRisorse = new ComboBox();
            btnAddRisorse = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Capienza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 146);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 224);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Risorse";
            // 
            // txtCapienza
            // 
            txtCapienza.Location = new Point(166, 66);
            txtCapienza.Name = "txtCapienza";
            txtCapienza.Size = new Size(100, 23);
            txtCapienza.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(166, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // cbxRisorse
            // 
            cbxRisorse.FormattingEnabled = true;
            cbxRisorse.Location = new Point(166, 224);
            cbxRisorse.Name = "cbxRisorse";
            cbxRisorse.Size = new Size(121, 23);
            cbxRisorse.TabIndex = 5;
            // 
            // btnAddRisorse
            // 
            btnAddRisorse.Location = new Point(351, 224);
            btnAddRisorse.Name = "btnAddRisorse";
            btnAddRisorse.Size = new Size(105, 23);
            btnAddRisorse.TabIndex = 6;
            btnAddRisorse.Text = "Add_Risorse";
            btnAddRisorse.UseVisualStyleBackColor = true;
            // 
            // FormAddAula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRisorse);
            Controls.Add(cbxRisorse);
            Controls.Add(txtNome);
            Controls.Add(txtCapienza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddAula";
            Text = "FormAddAula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCapienza;
        private TextBox txtNome;
        private ComboBox cbxRisorse;
        private Button btnAddRisorse;
    }
}