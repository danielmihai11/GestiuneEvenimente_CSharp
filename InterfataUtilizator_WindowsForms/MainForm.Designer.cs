namespace InterfataUtilizator_WindowsForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnParticipant = new System.Windows.Forms.Button();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(356, 132);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(297, 20);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold); // Schimbați fontul și dimensiunea textului
            this.lblTitlu.Text = "EventEase: Simplify Your Event Planning";
            this.lblTitlu.ForeColor = System.Drawing.Color.Blue; // Schimbați culoarea textului
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click);
            // 
            // btnParticipant
            // 
            this.btnParticipant.Location = new System.Drawing.Point(209, 310);
            this.btnParticipant.Name = "btnParticipant";
            this.btnParticipant.Size = new System.Drawing.Size(148, 81);
            this.btnParticipant.TabIndex = 1;
            this.btnParticipant.Text = "Participant";
            this.btnParticipant.UseVisualStyleBackColor = true;
            this.btnParticipant.BackColor = System.Drawing.Color.LightGreen; // Schimbați culoarea de fundal a butonului
            this.btnParticipant.ForeColor = System.Drawing.Color.DarkGreen; // Schimbați culoarea textului butonului
            this.btnParticipant.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold); // Schimbați fontul și dimensiunea textului
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Location = new System.Drawing.Point(659, 310);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(148, 81);
            this.btnAdministrator.TabIndex = 2;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = true;
            this.btnAdministrator.BackColor = System.Drawing.Color.LightGreen; // Schimbați culoarea de fundal a butonului
            this.btnAdministrator.ForeColor = System.Drawing.Color.DarkGreen; // Schimbați culoarea textului butonului
            this.btnAdministrator.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold); // Schimbați fontul și dimensiunea textului
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 557);
            this.BackColor = System.Drawing.Color.LightBlue; // Setează culoarea de fundal a formularului
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.btnParticipant);
            this.Controls.Add(this.lblTitlu);
            this.Name = "MainForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnParticipant;
        private System.Windows.Forms.Button btnAdministrator;
    }
}
