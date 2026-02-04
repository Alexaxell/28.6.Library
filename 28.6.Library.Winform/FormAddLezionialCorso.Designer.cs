namespace _28._6.Library.Winform
{
    partial class FormAddLezionialCorso
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDescrizione = new TextBox();
            txtOrarioDiInizio = new TextBox();
            txtDurata = new TextBox();
            txtDocente = new TextBox();
            txtAula = new TextBox();
            txtPresenti = new TextBox();
            dtpData = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            btnAddLezione = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 42);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrizione";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 89);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 151);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Orario di inizio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 211);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Durata";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 266);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Docente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 328);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Aula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 394);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 6;
            label7.Text = "Presenti";
            // 
            // txtDescrizione
            // 
            txtDescrizione.Location = new Point(180, 42);
            txtDescrizione.Name = "txtDescrizione";
            txtDescrizione.Size = new Size(100, 23);
            txtDescrizione.TabIndex = 7;
            // 
            // txtOrarioDiInizio
            // 
            txtOrarioDiInizio.Location = new Point(180, 151);
            txtOrarioDiInizio.Name = "txtOrarioDiInizio";
            txtOrarioDiInizio.Size = new Size(100, 23);
            txtOrarioDiInizio.TabIndex = 9;
            // 
            // txtDurata
            // 
            txtDurata.Location = new Point(180, 211);
            txtDurata.Name = "txtDurata";
            txtDurata.Size = new Size(100, 23);
            txtDurata.TabIndex = 10;
            // 
            // txtDocente
            // 
            txtDocente.Location = new Point(180, 266);
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new Size(100, 23);
            txtDocente.TabIndex = 11;
            // 
            // txtAula
            // 
            txtAula.Location = new Point(180, 328);
            txtAula.Name = "txtAula";
            txtAula.Size = new Size(100, 23);
            txtAula.TabIndex = 12;
            // 
            // txtPresenti
            // 
            txtPresenti.Location = new Point(180, 394);
            txtPresenti.Name = "txtPresenti";
            txtPresenti.Size = new Size(100, 23);
            txtPresenti.TabIndex = 13;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(180, 89);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(328, 266);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 15;
            button1.Text = "Add_Docente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 328);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 16;
            button2.Text = "Add_Aula";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddLezione
            // 
            btnAddLezione.Location = new Point(542, 50);
            btnAddLezione.Name = "btnAddLezione";
            btnAddLezione.Size = new Size(201, 176);
            btnAddLezione.TabIndex = 17;
            btnAddLezione.Text = "AddLezione";
            btnAddLezione.UseVisualStyleBackColor = true;
            btnAddLezione.Click += btnAddLezione_Click;
            // 
            // FormAddLezionialCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddLezione);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpData);
            Controls.Add(txtPresenti);
            Controls.Add(txtAula);
            Controls.Add(txtDocente);
            Controls.Add(txtDurata);
            Controls.Add(txtOrarioDiInizio);
            Controls.Add(txtDescrizione);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddLezionialCorso";
            Text = "FormAddLezionialCorso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDescrizione;
        private TextBox txtOrarioDiInizio;
        private TextBox txtDurata;
        private TextBox txtDocente;
        private TextBox txtAula;
        private TextBox txtPresenti;
        private DateTimePicker dtpData;
        private Button button1;
        private Button button2;
        private Button btnAddLezione;
    }
}