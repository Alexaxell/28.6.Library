namespace _28._6.Library.Winform
{
    partial class FormAddRisorsa
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
            txtAddRisorsa = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 73);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Risorsa";
            // 
            // txtAddRisorsa
            // 
            txtAddRisorsa.Location = new Point(169, 73);
            txtAddRisorsa.Name = "txtAddRisorsa";
            txtAddRisorsa.Size = new Size(186, 23);
            txtAddRisorsa.TabIndex = 1;
            // 
            // FormAddRisorsa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAddRisorsa);
            Controls.Add(label1);
            Name = "FormAddRisorsa";
            Text = "FormAddRisorsa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAddRisorsa;
    }
}