namespace _28._6.Library.Winform
{
    partial class FormAddCorso
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
            txtNomeCorso = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            Studenti = new Label();
            cbxStudenti = new ComboBox();
            label3 = new Label();
            cbxLezioni = new ComboBox();
            btnAddStudente = new Button();
            btnAddLezione = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 51);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome corso";
            // 
            // txtNomeCorso
            // 
            txtNomeCorso.Location = new Point(193, 51);
            txtNomeCorso.Name = "txtNomeCorso";
            txtNomeCorso.Size = new Size(100, 23);
            txtNomeCorso.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 108);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(193, 108);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // Studenti
            // 
            Studenti.AutoSize = true;
            Studenti.Location = new Point(67, 171);
            Studenti.Name = "Studenti";
            Studenti.Size = new Size(51, 15);
            Studenti.TabIndex = 4;
            Studenti.Text = "Studenti";
            // 
            // cbxStudenti
            // 
            cbxStudenti.FormattingEnabled = true;
            cbxStudenti.Location = new Point(193, 168);
            cbxStudenti.Name = "cbxStudenti";
            cbxStudenti.Size = new Size(121, 23);
            cbxStudenti.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 232);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Lezioni";
            // 
            // cbxLezioni
            // 
            cbxLezioni.FormattingEnabled = true;
            cbxLezioni.Location = new Point(193, 232);
            cbxLezioni.Name = "cbxLezioni";
            cbxLezioni.Size = new Size(121, 23);
            cbxLezioni.TabIndex = 7;
            // 
            // btnAddStudente
            // 
            btnAddStudente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudente.Location = new Point(363, 168);
            btnAddStudente.Name = "btnAddStudente";
            btnAddStudente.Size = new Size(34, 23);
            btnAddStudente.TabIndex = 8;
            btnAddStudente.Text = "+";
            btnAddStudente.UseVisualStyleBackColor = true;
            btnAddStudente.Click += btnAddStudente_Click;
            // 
            // btnAddLezione
            // 
            btnAddLezione.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLezione.Location = new Point(363, 232);
            btnAddLezione.Name = "btnAddLezione";
            btnAddLezione.Size = new Size(34, 23);
            btnAddLezione.TabIndex = 9;
            btnAddLezione.Text = "+";
            btnAddLezione.UseVisualStyleBackColor = true;
            btnAddLezione.Click += btnAddLezione_Click;
            // 
            // button1
            // 
            button1.Location = new Point(532, 89);
            button1.Name = "button1";
            button1.Size = new Size(149, 119);
            button1.TabIndex = 10;
            button1.Text = "AddCorso";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAddCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAddLezione);
            Controls.Add(btnAddStudente);
            Controls.Add(cbxLezioni);
            Controls.Add(label3);
            Controls.Add(cbxStudenti);
            Controls.Add(Studenti);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtNomeCorso);
            Controls.Add(label1);
            Name = "FormAddCorso";
            Text = "FormAddCorso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeCorso;
        private Label label2;
        private TextBox txtId;
        private Label Studenti;
        private ComboBox cbxStudenti;
        private Label label3;
        private ComboBox cbxLezioni;
        private Button btnAddStudente;
        private Button btnAddLezione;
        private Button button1;
    }
}