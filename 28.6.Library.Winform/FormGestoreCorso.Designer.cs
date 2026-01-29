namespace _28._6.Library.Winform
{
    partial class FormGestoreCorso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddCorso = new Button();
            btnAddLezioniAlCorso = new Button();
            btnAddStudentiAlCorso = new Button();
            btnGetAssentiAllaLezione = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 0;
            label1.Text = "GESTORE CORSI";
            // 
            // btnAddCorso
            // 
            btnAddCorso.Location = new Point(296, 103);
            btnAddCorso.Name = "btnAddCorso";
            btnAddCorso.Size = new Size(208, 54);
            btnAddCorso.TabIndex = 1;
            btnAddCorso.Text = "AddCorso";
            btnAddCorso.UseVisualStyleBackColor = true;
            btnAddCorso.Click += btnAddCorso_Click;
            // 
            // btnAddLezioniAlCorso
            // 
            btnAddLezioniAlCorso.Location = new Point(296, 163);
            btnAddLezioniAlCorso.Name = "btnAddLezioniAlCorso";
            btnAddLezioniAlCorso.Size = new Size(208, 54);
            btnAddLezioniAlCorso.TabIndex = 2;
            btnAddLezioniAlCorso.Text = "AddLezioniAlCorso";
            btnAddLezioniAlCorso.UseVisualStyleBackColor = true;
            btnAddLezioniAlCorso.Click += btnAddLezioniAlCorso_Click;
            // 
            // btnAddStudentiAlCorso
            // 
            btnAddStudentiAlCorso.Location = new Point(296, 223);
            btnAddStudentiAlCorso.Name = "btnAddStudentiAlCorso";
            btnAddStudentiAlCorso.Size = new Size(208, 54);
            btnAddStudentiAlCorso.TabIndex = 3;
            btnAddStudentiAlCorso.Text = "AddStudentiAlCorso";
            btnAddStudentiAlCorso.UseVisualStyleBackColor = true;
            btnAddStudentiAlCorso.Click += btnAddStudentiAlCorso_Click;
            // 
            // btnGetAssentiAllaLezione
            // 
            btnGetAssentiAllaLezione.Location = new Point(296, 283);
            btnGetAssentiAllaLezione.Name = "btnGetAssentiAllaLezione";
            btnGetAssentiAllaLezione.Size = new Size(208, 54);
            btnGetAssentiAllaLezione.TabIndex = 4;
            btnGetAssentiAllaLezione.Text = "GetAssentiAllaLezione";
            btnGetAssentiAllaLezione.UseVisualStyleBackColor = true;
            btnGetAssentiAllaLezione.Click += btnGetAssentiAllaLezione_Click;
            // 
            // FormGestoreCorso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetAssentiAllaLezione);
            Controls.Add(btnAddStudentiAlCorso);
            Controls.Add(btnAddLezioniAlCorso);
            Controls.Add(btnAddCorso);
            Controls.Add(label1);
            Name = "FormGestoreCorso";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddCorso;
        private Button btnAddLezioniAlCorso;
        private Button btnAddStudentiAlCorso;
        private Button btnGetAssentiAllaLezione;
    }
}
