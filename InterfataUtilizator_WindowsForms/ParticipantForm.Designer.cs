using System.Drawing;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    partial class ParticipantForm
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblEveniment = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtEveniment = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.lblMesajEroare = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridEvenimente = new System.Windows.Forms.DataGridView();
            this.txtCautareEvenimentLocatie = new System.Windows.Forms.TextBox();
            this.btnCautareEvenimentDupaLocatie = new System.Windows.Forms.Button();
            this.txtBoxCautareEvenimentData = new System.Windows.Forms.TextBox();
            this.btnCautareEvenimentData = new System.Windows.Forms.Button();
            this.txtCautareEvenimentTip = new System.Windows.Forms.TextBox();
            this.btnCautareTipEveniment = new System.Windows.Forms.Button();
            this.lblMesajEroareNume = new System.Windows.Forms.Label();
            this.lblMesajEroareEveniment = new System.Windows.Forms.Label();
            this.lblInscriereReusita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvenimente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNume.Location = new System.Drawing.Point(1316, 59);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(51, 20);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblEveniment
            // 
            this.lblEveniment.AutoSize = true;
            this.lblEveniment.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblEveniment.Location = new System.Drawing.Point(1316, 222);
            this.lblEveniment.Name = "lblEveniment";
            this.lblEveniment.Size = new System.Drawing.Size(84, 20);
            this.lblEveniment.TabIndex = 1;
            this.lblEveniment.Text = "Eveniment";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblVarsta.Location = new System.Drawing.Point(1316, 162);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(56, 20);
            this.lblVarsta.TabIndex = 2;
            this.lblVarsta.Text = "Varsta";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrenume.Location = new System.Drawing.Point(1316, 110);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(73, 20);
            this.lblPrenume.TabIndex = 4;
            this.lblPrenume.Text = "Prenume";
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.LightYellow;
            this.txtNume.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtNume.Location = new System.Drawing.Point(1426, 53);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(203, 26);
            this.txtNume.TabIndex = 5;
            // 
            // txtEveniment
            // 
            this.txtEveniment.BackColor = System.Drawing.Color.LightYellow;
            this.txtEveniment.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtEveniment.Location = new System.Drawing.Point(1426, 216);
            this.txtEveniment.Name = "txtEveniment";
            this.txtEveniment.Size = new System.Drawing.Size(203, 26);
            this.txtEveniment.TabIndex = 6;
            // 
            // txtVarsta
            // 
            this.txtVarsta.BackColor = System.Drawing.Color.LightYellow;
            this.txtVarsta.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtVarsta.Location = new System.Drawing.Point(1426, 159);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(203, 26);
            this.txtVarsta.TabIndex = 7;
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.Color.LightYellow;
            this.txtPrenume.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPrenume.Location = new System.Drawing.Point(1426, 104);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(203, 26);
            this.txtPrenume.TabIndex = 8;
            // 
            // lblMesajEroare
            // 
            this.lblMesajEroare.AutoSize = true;
            this.lblMesajEroare.ForeColor = System.Drawing.Color.Red;
            this.lblMesajEroare.Location = new System.Drawing.Point(67, 137);
            this.lblMesajEroare.Name = "lblMesajEroare";
            this.lblMesajEroare.Size = new System.Drawing.Size(0, 20);
            this.lblMesajEroare.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.Location = new System.Drawing.Point(1426, 278);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 61);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Inscriere";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // dataGridEvenimente
            // 
            this.dataGridEvenimente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEvenimente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvenimente.Location = new System.Drawing.Point(71, 28);
            this.dataGridEvenimente.Name = "dataGridEvenimente";
            this.dataGridEvenimente.RowHeadersWidth = 62;
            this.dataGridEvenimente.RowTemplate.Height = 28;
            this.dataGridEvenimente.Size = new System.Drawing.Size(800, 274);
            this.dataGridEvenimente.TabIndex = 10;
            // 
            // txtCautareEvenimentLocatie
            // 
            this.txtCautareEvenimentLocatie.BackColor = System.Drawing.Color.LightYellow;
            this.txtCautareEvenimentLocatie.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCautareEvenimentLocatie.Location = new System.Drawing.Point(1320, 427);
            this.txtCautareEvenimentLocatie.Name = "txtCautareEvenimentLocatie";
            this.txtCautareEvenimentLocatie.Size = new System.Drawing.Size(203, 26);
            this.txtCautareEvenimentLocatie.TabIndex = 12;
            // 
            // btnCautareEvenimentDupaLocatie
            // 
            this.btnCautareEvenimentDupaLocatie.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareEvenimentDupaLocatie.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareEvenimentDupaLocatie.Location = new System.Drawing.Point(1548, 408);
            this.btnCautareEvenimentDupaLocatie.Name = "btnCautareEvenimentDupaLocatie";
            this.btnCautareEvenimentDupaLocatie.Size = new System.Drawing.Size(107, 64);
            this.btnCautareEvenimentDupaLocatie.TabIndex = 13;
            this.btnCautareEvenimentDupaLocatie.Text = "Cautare locatie";
            this.btnCautareEvenimentDupaLocatie.UseVisualStyleBackColor = false;
            this.btnCautareEvenimentDupaLocatie.Click += new System.EventHandler(this.btnCautareEvenimentDupaLocatie_Click);
            this.btnCautareEvenimentDupaLocatie.MouseEnter += new System.EventHandler(this.btnCautareEvenimentDupaLocatie_MouseEnter);
            this.btnCautareEvenimentDupaLocatie.MouseLeave += new System.EventHandler(this.btnCautareEvenimentDupaLocatie_MouseLeave);
            // 
            // txtBoxCautareEvenimentData
            // 
            this.txtBoxCautareEvenimentData.BackColor = System.Drawing.Color.LightYellow;
            this.txtBoxCautareEvenimentData.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtBoxCautareEvenimentData.Location = new System.Drawing.Point(1320, 519);
            this.txtBoxCautareEvenimentData.Name = "txtBoxCautareEvenimentData";
            this.txtBoxCautareEvenimentData.Size = new System.Drawing.Size(203, 26);
            this.txtBoxCautareEvenimentData.TabIndex = 14;
            // 
            // btnCautareEvenimentData
            // 
            this.btnCautareEvenimentData.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareEvenimentData.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareEvenimentData.Location = new System.Drawing.Point(1548, 500);
            this.btnCautareEvenimentData.Name = "btnCautareEvenimentData";
            this.btnCautareEvenimentData.Size = new System.Drawing.Size(107, 64);
            this.btnCautareEvenimentData.TabIndex = 15;
            this.btnCautareEvenimentData.Text = "Cautare data";
            this.btnCautareEvenimentData.UseVisualStyleBackColor = false;
            this.btnCautareEvenimentData.Click += new System.EventHandler(this.btnCautareEvenimentData_Click);
            this.btnCautareEvenimentData.MouseEnter += new System.EventHandler(this.btnCautareEvenimentData_MouseEnter);
            this.btnCautareEvenimentData.MouseLeave += new System.EventHandler(this.btnCautareEvenimentData_MouseLeave);
            // 
            // txtCautareEvenimentTip
            // 
            this.txtCautareEvenimentTip.BackColor = System.Drawing.Color.LightYellow;
            this.txtCautareEvenimentTip.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCautareEvenimentTip.Location = new System.Drawing.Point(1320, 619);
            this.txtCautareEvenimentTip.Name = "txtCautareEvenimentTip";
            this.txtCautareEvenimentTip.Size = new System.Drawing.Size(203, 26);
            this.txtCautareEvenimentTip.TabIndex = 16;
            // 
            // btnCautareTipEveniment
            // 
            this.btnCautareTipEveniment.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareTipEveniment.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareTipEveniment.Location = new System.Drawing.Point(1548, 600);
            this.btnCautareTipEveniment.Name = "btnCautareTipEveniment";
            this.btnCautareTipEveniment.Size = new System.Drawing.Size(107, 64);
            this.btnCautareTipEveniment.TabIndex = 17;
            this.btnCautareTipEveniment.Text = "Cautare tip";
            this.btnCautareTipEveniment.UseVisualStyleBackColor = false;
            this.btnCautareTipEveniment.Click += new System.EventHandler(this.btnCautareTipEveniment_Click);
            this.btnCautareTipEveniment.MouseEnter += new System.EventHandler(this.btnCautareTipEveniment_MouseEnter);
            this.btnCautareTipEveniment.MouseLeave += new System.EventHandler(this.btnCautareTipEveniment_MouseLeave);
            // 
            // lblMesajEroareNume
            // 
            this.lblMesajEroareNume.AutoSize = true;
            this.lblMesajEroareNume.Location = new System.Drawing.Point(1321, 28);
            this.lblMesajEroareNume.Name = "lblMesajEroareNume";
            this.lblMesajEroareNume.Size = new System.Drawing.Size(0, 20);
            this.lblMesajEroareNume.TabIndex = 18;
            // 
            // lblMesajEroareEveniment
            // 
            this.lblMesajEroareEveniment.AutoSize = true;
            this.lblMesajEroareEveniment.ForeColor = System.Drawing.Color.Red;
            this.lblMesajEroareEveniment.Location = new System.Drawing.Point(67, 386);
            this.lblMesajEroareEveniment.Name = "lblMesajEroareEveniment";
            this.lblMesajEroareEveniment.Size = new System.Drawing.Size(0, 20);
            this.lblMesajEroareEveniment.TabIndex = 19;
            // 
            // lblInscriereReusita
            // 
            this.lblInscriereReusita.AutoSize = true;
            this.lblInscriereReusita.ForeColor = System.Drawing.Color.Green;
            this.lblInscriereReusita.Location = new System.Drawing.Point(67, 365);
            this.lblInscriereReusita.Name = "lblInscriereReusita";
            this.lblInscriereReusita.Size = new System.Drawing.Size(0, 20);
            this.lblInscriereReusita.TabIndex = 20;
            // 
            // ParticipantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1734, 888);
            this.Controls.Add(this.lblInscriereReusita);
            this.Controls.Add(this.lblMesajEroareEveniment);
            this.Controls.Add(this.lblMesajEroareNume);
            this.Controls.Add(this.btnCautareTipEveniment);
            this.Controls.Add(this.txtCautareEvenimentTip);
            this.Controls.Add(this.btnCautareEvenimentData);
            this.Controls.Add(this.txtBoxCautareEvenimentData);
            this.Controls.Add(this.btnCautareEvenimentDupaLocatie);
            this.Controls.Add(this.txtCautareEvenimentLocatie);
            this.Controls.Add(this.lblMesajEroare);
            this.Controls.Add(this.dataGridEvenimente);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.txtEveniment);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblVarsta);
            this.Controls.Add(this.lblEveniment);
            this.Controls.Add(this.lblNume);
            this.Name = "ParticipantForm";
            this.Text = "Participant";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvenimente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblEveniment;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtEveniment;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMesajEroare;
        private DataGridView dataGridEvenimente;
        private TextBox txtCautareEvenimentLocatie;
        private Button btnCautareEvenimentDupaLocatie;
        private TextBox txtBoxCautareEvenimentData;
        private Button btnCautareEvenimentData;
        private TextBox txtCautareEvenimentTip;
        private Button btnCautareTipEveniment;
        private Label lblMesajEroareNume;
        private Label lblMesajEroareEveniment;
        private Label lblInscriereReusita;
    }
}