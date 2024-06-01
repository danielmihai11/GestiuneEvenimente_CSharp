using System.Drawing;

namespace InterfataUtilizator_WindowsForms
{
    partial class AdministratorForm
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
            this.lblDenumire = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtOra = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.rdbCorporativ = new System.Windows.Forms.RadioButton();
            this.rdbSocial = new System.Windows.Forms.RadioButton();
            this.rdbCultural = new System.Windows.Forms.RadioButton();
            this.rdbSportiv = new System.Windows.Forms.RadioButton();
            this.rdbEducational = new System.Windows.Forms.RadioButton();
            this.rdbCaritabil = new System.Windows.Forms.RadioButton();
            this.rdbPolitic = new System.Windows.Forms.RadioButton();
            this.rdbReligios = new System.Windows.Forms.RadioButton();
            this.rdbNetworking = new System.Windows.Forms.RadioButton();
            this.rdbVirtual = new System.Windows.Forms.RadioButton();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.dataGridEvenimente = new System.Windows.Forms.DataGridView();
            this.lblMesajEroare = new System.Windows.Forms.Label();
            this.txtCautareLocatie = new System.Windows.Forms.TextBox();
            this.txtCautareData = new System.Windows.Forms.TextBox();
            this.txtCautareEveniment = new System.Windows.Forms.TextBox();
            this.btnCautareLocatie = new System.Windows.Forms.Button();
            this.btnCautareData = new System.Windows.Forms.Button();
            this.btnCautareEveniment = new System.Windows.Forms.Button();
            this.lblCautare = new System.Windows.Forms.Label();
            this.lblAntetTip = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvenimente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDenumire.Location = new System.Drawing.Point(23, 47);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(78, 20);
            this.lblDenumire.TabIndex = 0;
            this.lblDenumire.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.BackColor = System.Drawing.Color.LightYellow;
            this.txtDenumire.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtDenumire.Location = new System.Drawing.Point(124, 44);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(208, 26);
            this.txtDenumire.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblData.Location = new System.Drawing.Point(23, 91);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.LightYellow;
            this.txtData.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtData.Location = new System.Drawing.Point(124, 91);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(208, 26);
            this.txtData.TabIndex = 3;
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLocatie.Location = new System.Drawing.Point(23, 140);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(61, 20);
            this.lblLocatie.TabIndex = 4;
            this.lblLocatie.Text = "Locație";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOra.Location = new System.Drawing.Point(23, 188);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(35, 20);
            this.lblOra.TabIndex = 5;
            this.lblOra.Text = "Ora";
            // 
            // txtLocatie
            // 
            this.txtLocatie.BackColor = System.Drawing.Color.LightYellow;
            this.txtLocatie.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLocatie.Location = new System.Drawing.Point(124, 140);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(208, 26);
            this.txtLocatie.TabIndex = 6;
            // 
            // txtOra
            // 
            this.txtOra.BackColor = System.Drawing.Color.LightYellow;
            this.txtOra.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtOra.Location = new System.Drawing.Point(124, 185);
            this.txtOra.Name = "txtOra";
            this.txtOra.Size = new System.Drawing.Size(208, 26);
            this.txtOra.TabIndex = 7;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTip.Location = new System.Drawing.Point(12, 329);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(107, 20);
            this.lblTip.TabIndex = 9;
            this.lblTip.Text = "Tip eveniment";
            // 
            // rdbCorporativ
            // 
            this.rdbCorporativ.AutoSize = true;
            this.rdbCorporativ.Location = new System.Drawing.Point(150, 258);
            this.rdbCorporativ.Name = "rdbCorporativ";
            this.rdbCorporativ.Size = new System.Drawing.Size(106, 24);
            this.rdbCorporativ.TabIndex = 10;
            this.rdbCorporativ.TabStop = true;
            this.rdbCorporativ.Text = "Corporativ";
            this.rdbCorporativ.UseVisualStyleBackColor = true;
            // 
            // rdbSocial
            // 
            this.rdbSocial.AutoSize = true;
            this.rdbSocial.Location = new System.Drawing.Point(279, 258);
            this.rdbSocial.Name = "rdbSocial";
            this.rdbSocial.Size = new System.Drawing.Size(77, 24);
            this.rdbSocial.TabIndex = 11;
            this.rdbSocial.TabStop = true;
            this.rdbSocial.Text = "Social";
            this.rdbSocial.UseVisualStyleBackColor = true;
            // 
            // rdbCultural
            // 
            this.rdbCultural.AutoSize = true;
            this.rdbCultural.Location = new System.Drawing.Point(150, 302);
            this.rdbCultural.Name = "rdbCultural";
            this.rdbCultural.Size = new System.Drawing.Size(88, 24);
            this.rdbCultural.TabIndex = 12;
            this.rdbCultural.TabStop = true;
            this.rdbCultural.Text = "Cultural";
            this.rdbCultural.UseVisualStyleBackColor = true;
            // 
            // rdbSportiv
            // 
            this.rdbSportiv.AutoSize = true;
            this.rdbSportiv.Location = new System.Drawing.Point(279, 302);
            this.rdbSportiv.Name = "rdbSportiv";
            this.rdbSportiv.Size = new System.Drawing.Size(83, 24);
            this.rdbSportiv.TabIndex = 13;
            this.rdbSportiv.TabStop = true;
            this.rdbSportiv.Text = "Sportiv";
            this.rdbSportiv.UseVisualStyleBackColor = true;
            // 
            // rdbEducational
            // 
            this.rdbEducational.AutoSize = true;
            this.rdbEducational.Location = new System.Drawing.Point(150, 348);
            this.rdbEducational.Name = "rdbEducational";
            this.rdbEducational.Size = new System.Drawing.Size(118, 24);
            this.rdbEducational.TabIndex = 14;
            this.rdbEducational.TabStop = true;
            this.rdbEducational.Text = "Educational";
            this.rdbEducational.UseVisualStyleBackColor = true;
            // 
            // rdbCaritabil
            // 
            this.rdbCaritabil.AutoSize = true;
            this.rdbCaritabil.Location = new System.Drawing.Point(279, 348);
            this.rdbCaritabil.Name = "rdbCaritabil";
            this.rdbCaritabil.Size = new System.Drawing.Size(91, 24);
            this.rdbCaritabil.TabIndex = 15;
            this.rdbCaritabil.TabStop = true;
            this.rdbCaritabil.Text = "Caritabil";
            this.rdbCaritabil.UseVisualStyleBackColor = true;
            // 
            // rdbPolitic
            // 
            this.rdbPolitic.AutoSize = true;
            this.rdbPolitic.Location = new System.Drawing.Point(150, 388);
            this.rdbPolitic.Name = "rdbPolitic";
            this.rdbPolitic.Size = new System.Drawing.Size(75, 24);
            this.rdbPolitic.TabIndex = 16;
            this.rdbPolitic.TabStop = true;
            this.rdbPolitic.Text = "Politic";
            this.rdbPolitic.UseVisualStyleBackColor = true;
            // 
            // rdbReligios
            // 
            this.rdbReligios.AutoSize = true;
            this.rdbReligios.Location = new System.Drawing.Point(280, 388);
            this.rdbReligios.Name = "rdbReligios";
            this.rdbReligios.Size = new System.Drawing.Size(90, 24);
            this.rdbReligios.TabIndex = 17;
            this.rdbReligios.TabStop = true;
            this.rdbReligios.Text = "Religios";
            this.rdbReligios.UseVisualStyleBackColor = true;
            // 
            // rdbNetworking
            // 
            this.rdbNetworking.AutoSize = true;
            this.rdbNetworking.Location = new System.Drawing.Point(150, 431);
            this.rdbNetworking.Name = "rdbNetworking";
            this.rdbNetworking.Size = new System.Drawing.Size(113, 24);
            this.rdbNetworking.TabIndex = 18;
            this.rdbNetworking.TabStop = true;
            this.rdbNetworking.Text = "Networking";
            this.rdbNetworking.UseVisualStyleBackColor = true;
            // 
            // rdbVirtual
            // 
            this.rdbVirtual.AutoSize = true;
            this.rdbVirtual.Location = new System.Drawing.Point(280, 431);
            this.rdbVirtual.Name = "rdbVirtual";
            this.rdbVirtual.Size = new System.Drawing.Size(79, 24);
            this.rdbVirtual.TabIndex = 19;
            this.rdbVirtual.TabStop = true;
            this.rdbVirtual.Text = "Virtual";
            this.rdbVirtual.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdauga.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdauga.Location = new System.Drawing.Point(27, 514);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(101, 43);
            this.btnAdauga.TabIndex = 20;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            this.btnAdauga.MouseEnter += new System.EventHandler(this.btnAdauga_MouseEnter);
            this.btnAdauga.MouseLeave += new System.EventHandler(this.btnAdauga_MouseLeave);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Location = new System.Drawing.Point(143, 514);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 43);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnAfiseaza_Click);
            this.btnRefresh.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // lstAfisare
            // 
            this.lstAfisare.ForeColor = System.Drawing.Color.DarkBlue;
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 20;
            this.lstAfisare.Location = new System.Drawing.Point(524, 461);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(686, 164);
            this.lstAfisare.TabIndex = 22;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // dataGridEvenimente
            // 
            this.dataGridEvenimente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEvenimente.Location = new System.Drawing.Point(524, 678);
            this.dataGridEvenimente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.dataGridEvenimente.Name = "dataGridEvenimente";
            this.dataGridEvenimente.RowHeadersWidth = 62;
            this.dataGridEvenimente.RowTemplate.Height = 28;
            this.dataGridEvenimente.Size = new System.Drawing.Size(686, 189);
            this.dataGridEvenimente.TabIndex = 43;
            // 
            // lblMesajEroare
            // 
            this.lblMesajEroare.AutoSize = true;
            this.lblMesajEroare.ForeColor = System.Drawing.Color.Red;
            this.lblMesajEroare.Location = new System.Drawing.Point(20, 470);
            this.lblMesajEroare.Name = "lblMesajEroare";
            this.lblMesajEroare.Size = new System.Drawing.Size(0, 20);
            this.lblMesajEroare.TabIndex = 44;
            // 
            // txtCautareLocatie
            // 
            this.txtCautareLocatie.BackColor = System.Drawing.Color.LightYellow;
            this.txtCautareLocatie.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCautareLocatie.Location = new System.Drawing.Point(1195, 236);
            this.txtCautareLocatie.Name = "txtCautareLocatie";
            this.txtCautareLocatie.Size = new System.Drawing.Size(214, 26);
            this.txtCautareLocatie.TabIndex = 46;
            // 
            // txtCautareData
            // 
            this.txtCautareData.BackColor = System.Drawing.Color.LightYellow;
            this.txtCautareData.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCautareData.Location = new System.Drawing.Point(1195, 329);
            this.txtCautareData.Name = "txtCautareData";
            this.txtCautareData.Size = new System.Drawing.Size(214, 26);
            this.txtCautareData.TabIndex = 47;
            // 
            // txtCautareEveniment
            // 
            this.txtCautareEveniment.BackColor = System.Drawing.Color.LightYellow;
            this.txtCautareEveniment.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCautareEveniment.Location = new System.Drawing.Point(1195, 140);
            this.txtCautareEveniment.Name = "txtCautareEveniment";
            this.txtCautareEveniment.Size = new System.Drawing.Size(214, 26);
            this.txtCautareEveniment.TabIndex = 48;
            // 
            // btnCautareLocatie
            // 
            this.btnCautareLocatie.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareLocatie.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareLocatie.Location = new System.Drawing.Point(1428, 215);
            this.btnCautareLocatie.Name = "btnCautareLocatie";
            this.btnCautareLocatie.Size = new System.Drawing.Size(120, 68);
            this.btnCautareLocatie.TabIndex = 49;
            this.btnCautareLocatie.Text = "Cautare locație";
            this.btnCautareLocatie.UseVisualStyleBackColor = false;
            this.btnCautareLocatie.Click += new System.EventHandler(this.BtnCautareLocatie_Click);
            this.btnCautareLocatie.MouseEnter += new System.EventHandler(this.btnCautareLocatie_MouseEnter);
            this.btnCautareLocatie.MouseLeave += new System.EventHandler(this.btnCautareLocatie_MouseLeave);
            // 
            // btnCautareData
            // 
            this.btnCautareData.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareData.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareData.Location = new System.Drawing.Point(1428, 305);
            this.btnCautareData.Name = "btnCautareData";
            this.btnCautareData.Size = new System.Drawing.Size(120, 68);
            this.btnCautareData.TabIndex = 50;
            this.btnCautareData.Text = "Căutare după dată";
            this.btnCautareData.UseVisualStyleBackColor = false;
            this.btnCautareData.Click += new System.EventHandler(this.BtnCautareData_Click);
            this.btnCautareData.MouseEnter += new System.EventHandler(this.btnCautareData_MouseEnter);
            this.btnCautareData.MouseLeave += new System.EventHandler(this.btnCautareData_MouseLeave);
            // 
            // btnCautareEveniment
            // 
            this.btnCautareEveniment.BackColor = System.Drawing.Color.LightGreen;
            this.btnCautareEveniment.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCautareEveniment.Location = new System.Drawing.Point(1428, 119);
            this.btnCautareEveniment.Name = "btnCautareEveniment";
            this.btnCautareEveniment.Size = new System.Drawing.Size(120, 68);
            this.btnCautareEveniment.TabIndex = 51;
            this.btnCautareEveniment.Text = "Căutare eveniment";
            this.btnCautareEveniment.UseVisualStyleBackColor = false;
            this.btnCautareEveniment.Click += new System.EventHandler(this.BtnCautareEveniment_Click);
            this.btnCautareEveniment.MouseEnter += new System.EventHandler(this.btnCautareEveniment_MouseEnter);
            this.btnCautareEveniment.MouseLeave += new System.EventHandler(this.btnCautareEveniment_MouseLeave);
            // 
            // lblCautare
            // 
            this.lblCautare.AutoSize = true;
            this.lblCautare.ForeColor = System.Drawing.Color.Red;
            this.lblCautare.Location = new System.Drawing.Point(1469, 86);
            this.lblCautare.Name = "lblCautare";
            this.lblCautare.Size = new System.Drawing.Size(0, 20);
            this.lblCautare.TabIndex = 52;
            // 
            // lblAntetTip
            // 
            this.lblAntetTip.ForeColor = System.Drawing.Color.Red;
            this.lblAntetTip.Location = new System.Drawing.Point(0, 0);
            this.lblAntetTip.Name = "lblAntetTip";
            this.lblAntetTip.Size = new System.Drawing.Size(100, 23);
            this.lblAntetTip.TabIndex = 0;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.LightGreen;
            this.btnModifica.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnModifica.Location = new System.Drawing.Point(252, 514);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(104, 43);
            this.btnModifica.TabIndex = 53;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            this.btnModifica.MouseEnter += new System.EventHandler(this.btnModifica_MouseEnter);
            this.btnModifica.MouseLeave += new System.EventHandler(this.btnModifica_MouseLeave);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.LightGreen;
            this.btnSterge.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSterge.Location = new System.Drawing.Point(374, 514);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(92, 43);
            this.btnSterge.TabIndex = 54;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            this.btnSterge.MouseEnter += new System.EventHandler(this.btnSterge_MouseEnter);
            this.btnSterge.MouseLeave += new System.EventHandler(this.btnSterge_MouseLeave);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1765, 967);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblCautare);
            this.Controls.Add(this.btnCautareEveniment);
            this.Controls.Add(this.btnCautareData);
            this.Controls.Add(this.btnCautareLocatie);
            this.Controls.Add(this.txtCautareEveniment);
            this.Controls.Add(this.txtCautareData);
            this.Controls.Add(this.txtCautareLocatie);
            this.Controls.Add(this.dataGridEvenimente);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.rdbVirtual);
            this.Controls.Add(this.rdbNetworking);
            this.Controls.Add(this.rdbReligios);
            this.Controls.Add(this.rdbPolitic);
            this.Controls.Add(this.rdbCaritabil);
            this.Controls.Add(this.rdbEducational);
            this.Controls.Add(this.rdbSportiv);
            this.Controls.Add(this.rdbCultural);
            this.Controls.Add(this.rdbSocial);
            this.Controls.Add(this.rdbCorporativ);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtOra);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.lblMesajEroare);
            this.Name = "AdministratorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEvenimente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtOra;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.RadioButton rdbCorporativ;
        private System.Windows.Forms.RadioButton rdbSocial;
        private System.Windows.Forms.RadioButton rdbCultural;
        private System.Windows.Forms.RadioButton rdbSportiv;
        private System.Windows.Forms.RadioButton rdbEducational;
        private System.Windows.Forms.RadioButton rdbCaritabil;
        private System.Windows.Forms.RadioButton rdbPolitic;
        private System.Windows.Forms.RadioButton rdbReligios;
        private System.Windows.Forms.RadioButton rdbNetworking;
        private System.Windows.Forms.RadioButton rdbVirtual;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.DataGridView dataGridEvenimente;
        private System.Windows.Forms.Label lblMesajEroare; // Declarare label eroare
        private System.Windows.Forms.TextBox txtCautareLocatie;
        private System.Windows.Forms.TextBox txtCautareData;
        private System.Windows.Forms.TextBox txtCautareEveniment;
        private System.Windows.Forms.Button btnCautareLocatie;
        private System.Windows.Forms.Button btnCautareData;
        private System.Windows.Forms.Button btnCautareEveniment;
        private System.Windows.Forms.Label lblCautare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;

        ///private System.Windows.Forms.Label lblAntetTip; // Declarare lblAntetTip
    }
}