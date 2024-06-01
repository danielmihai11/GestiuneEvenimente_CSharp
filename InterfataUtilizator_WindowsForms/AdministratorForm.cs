using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele.Enumerari;
using System.Collections;
using System.Drawing.Text;
using System.Runtime.Remoting.Messaging;

namespace InterfataUtilizator_WindowsForms
{
    public partial class AdministratorForm : Form
    {
        private const int NRMAXCARACTERE = 20;
        IStocareDataEvenimente adminEvenimentef;
        IStocareDataParticipanti adminParticipantif;

        private Label lblAntetDenumire;
        private Label lblAntetData;
        private Label lblAntetOra;
        private Label lblAntetLocatie;
        private Label lblAntetTip;

        private Label[] lblsDenumire;
        private Label[] lblsData;
        private Label[] lblsLocatie;
        private Label[] lblsOra;
        private Label[] lblsTip;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;
        private const int OFFSET_X = 300;



        public AdministratorForm()
        {
            InitializeComponent();
            adminEvenimentef = StocareFactory.GetAdministratorStocareEvenimente();
            adminParticipantif = StocareFactory.GetAdministratorStocareParticipanti();

            this.Load += new EventHandler(Form1_Load);

            this.Size = new Size(950, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Blue;
            this.Text = "Informatii evenimente";
            this.BackColor = Color.LightBlue;

            lblAntetDenumire = new Label();
            lblAntetDenumire.Width = LATIME_CONTROL;
            lblAntetDenumire.Text = "Denumire";
            lblAntetDenumire.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblAntetDenumire.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAntetDenumire);

            lblAntetData = new Label();
            lblAntetData.Width = LATIME_CONTROL;
            lblAntetData.Text = "Data";
            lblAntetData.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblAntetData.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAntetData);

            lblAntetLocatie = new Label();
            lblAntetLocatie.Width = LATIME_CONTROL;
            lblAntetLocatie.Text = "Locatie";
            lblAntetLocatie.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblAntetLocatie.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAntetLocatie);

            lblAntetOra = new Label();
            lblAntetOra.Width = LATIME_CONTROL;
            lblAntetOra.Text = "Ora";
            lblAntetOra.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblAntetOra.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAntetOra);

            lblAntetTip = new Label();
            lblAntetTip.Width = LATIME_CONTROL;
            lblAntetTip.Text = "Tip eveniment";
            lblAntetTip.Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
            lblAntetTip.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblAntetTip);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
            AfiseazaEvenimente();
            AfisareEvenimenteInControlListbox(evenimente);
            AfisareEvenimenteInControlDataGridView(evenimente);


        }

        private void AfiseazaEvenimente()
        {
            if (lblsDenumire != null)
            {
                foreach (Label lbl in lblsDenumire) this.Controls.Remove(lbl);
                foreach (Label lbl in lblsData) this.Controls.Remove(lbl);
                foreach (Label lbl in lblsLocatie) this.Controls.Remove(lbl);
                foreach (Label lbl in lblsOra) this.Controls.Remove(lbl);
                foreach (Label lbl in lblsTip) this.Controls.Remove(lbl);
            }
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
            int nrEvenimente = evenimente.Count;

            lblsDenumire = new Label[nrEvenimente];
            lblsData = new Label[nrEvenimente];
            lblsLocatie = new Label[nrEvenimente];
            lblsOra = new Label[nrEvenimente];
            lblsTip = new Label[nrEvenimente];

            int i = 0;
            foreach (Eveniment eveniment in evenimente)
            {
                lblsDenumire[i] = new Label();
                lblsDenumire[i].Width = LATIME_CONTROL;
                lblsDenumire[i].Text = eveniment.denumire;
                lblsDenumire[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsDenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsDenumire[i].ForeColor = Color.DarkBlue; 
                this.Controls.Add(lblsDenumire[i]);

                lblsData[i] = new Label();
                lblsData[i].Width = LATIME_CONTROL;
                lblsData[i].Text = eveniment.data;
                lblsData[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsData[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsData[i].ForeColor = Color.DarkBlue;
                this.Controls.Add(lblsData[i]);

                lblsLocatie[i] = new Label();
                lblsLocatie[i].Width = LATIME_CONTROL;
                lblsLocatie[i].Text = eveniment.locatie;
                lblsLocatie[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsLocatie[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsLocatie[i].ForeColor = Color.DarkBlue;
                this.Controls.Add(lblsLocatie[i]);

                lblsOra[i] = new Label();
                lblsOra[i].Width = LATIME_CONTROL;
                lblsOra[i].Text = eveniment.ora;
                lblsOra[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
                lblsOra[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsOra[i].ForeColor = Color.DarkBlue;
                this.Controls.Add(lblsOra[i]);

                lblsTip[i] = new Label();
                lblsTip[i].Width = LATIME_CONTROL;
                lblsTip[i].Text = eveniment.tip.ToString();
                lblsTip[i].Left = OFFSET_X + 5 * DIMENSIUNE_PAS_X;
                lblsTip[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                lblsTip[i].ForeColor = Color.DarkBlue; 
                this.Controls.Add(lblsTip[i]);

                i++;

            }
        }

        private void BtnCautareEveniment_Click(object sender, EventArgs e)
        {
            string denumire = txtCautareEveniment.Text.Trim();
            if (string.IsNullOrEmpty(denumire))
            {
                lblMesajEroare.Text = "Introduceti denumirea evenimentului!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            List<Eveniment> evenimenteGasite = adminEvenimentef.GetEvenimentDenumire(denumire);
            if (evenimenteGasite == null || evenimenteGasite.Count == 0)
            {
                lblMesajEroare.Text = "Nu a fost gasit niciun eveniment cu aceasta denumire!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            AfiseazaParticipantiEveniment(denumire);
        }

        private void AfiseazaParticipantiEveniment(string denumireEveniment)
        {
            List<Participant> participanti = adminParticipantif.GetParticipantEveniment(denumireEveniment);
            lstAfisare.Items.Clear();
            foreach (Participant participant in participanti)
            {
                lstAfisare.Items.Add($"{participant.nume} {participant.prenume}");
            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nume");
            dataTable.Columns.Add("Prenume");
            dataTable.Columns.Add("Varsta");
            dataTable.Columns.Add("Eveniment");

            foreach (Participant participant in participanti)
            {
                dataTable.Rows.Add(participant.nume, participant.prenume, participant.varsta, participant.eveniment);
            }

            dataGridEvenimente.DataSource = dataTable;
        }
        private void BtnCautareLocatie_Click(object sender, EventArgs e)
        {
            string locatie = txtCautareLocatie.Text.Trim();

            if (string.IsNullOrEmpty(locatie))
            {
                lblMesajEroare.Text = "Introduceți locația evenimentului!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            List<Eveniment> evenimenteGasite = adminEvenimentef.GetEvenimentLocatie(locatie);

            if (evenimenteGasite.Count == 0)
            {
                lblMesajEroare.Text = "Nu s-au găsit evenimente pentru locația specificată!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            AfiseazaEvenimenteGasite(evenimenteGasite);
            lblMesajEroare.Text = string.Empty;
        }

        private void BtnCautareData_Click(object sender, EventArgs e)
        {
            string data = txtCautareData.Text.Trim();

            if (string.IsNullOrEmpty(data))
            {
                lblMesajEroare.Text = "Introduceți data evenimentului!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            List<Eveniment> evenimenteGasite = adminEvenimentef.GetEvenimentData(data);

            if (evenimenteGasite.Count == 0)
            {
                lblMesajEroare.Text = "Nu s-au găsit evenimente pentru data specificată!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            AfiseazaEvenimenteGasite(evenimenteGasite);
            lblMesajEroare.Text = string.Empty;
        }

        private void AfiseazaEvenimenteGasite(List<Eveniment> evenimente)
        {
            lstAfisare.Items.Clear();
            foreach (Eveniment eveniment in evenimente)
            {
                lstAfisare.Items.Add(eveniment);
            }

            dataGridEvenimente.DataSource = null;
            dataGridEvenimente.DataSource = evenimente;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {


            if (!DateIntrareValide())
            {
                lblDenumire.ForeColor = Color.Red;
                return;
            }


            Eveniment eveniment = new Eveniment(txtDenumire.Text, txtData.Text, txtLocatie.Text, txtOra.Text);
            TipEveniment tipSelectat = GetTipEvenimentSelectat();
            eveniment.tip = tipSelectat;



            adminEvenimentef.AddEveniment(eveniment);
            lblMesajEroare.Text = "Eveniment adaugat cu succes!";
            lblMesajEroare.ForeColor = Color.Green;
            lblMesajEroare.Visible = true;

            ResetareControale();
        }
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
            AfiseazaEvenimente();
            AfisareEvenimenteInControlListbox(evenimente);
            AfisareEvenimenteInControlDataGridView(evenimente);

            lblMesajEroare.Text = "Afisare incarcata cu succes!";
            lblMesajEroare.ForeColor = Color.Green;

        }
        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAfisare.SelectedItem != null)
            {
                Eveniment evenimentSelectat = (Eveniment)lstAfisare.SelectedItem;
                txtDenumire.Text = evenimentSelectat.denumire;
                txtData.Text = evenimentSelectat.data;
                txtLocatie.Text = evenimentSelectat.locatie;
                txtOra.Text = evenimentSelectat.ora;
                SetTipEveniment(evenimentSelectat.tip);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (lstAfisare.SelectedItem != null)
            {
                Eveniment evenimentSelectat = (Eveniment)lstAfisare.SelectedItem;

                evenimentSelectat.denumire = txtDenumire.Text;
                evenimentSelectat.data = txtData.Text;
                evenimentSelectat.locatie = txtLocatie.Text;
                evenimentSelectat.ora = txtOra.Text;
                evenimentSelectat.tip = GetTipEvenimentSelectat();

                adminEvenimentef.UpdateEveniment(evenimentSelectat);

                lblMesajEroare.Text = "Eveniment modificat cu succes!";
                lblMesajEroare.ForeColor = Color.Green;

                List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
                AfisareEvenimenteInControlListbox(evenimente);
                AfisareEvenimenteInControlDataGridView(evenimente);
                AfiseazaEvenimente();

                lblMesajEroare.Text = "Modificare realizată cu succes!";
                lblMesajEroare.ForeColor = Color.Green;
            }
            else
            {
                lblMesajEroare.Text = "Selectați un eveniment din listă pentru a-l modifica.";
                lblMesajEroare.ForeColor = Color.Red;
            }
        }



        private void SetTipEveniment(TipEveniment tip)
        {
            switch (tip)
            {
                case TipEveniment.Corporativ:
                    rdbCorporativ.Checked = true;
                    break;
                case TipEveniment.Social:
                    rdbSocial.Checked = true;
                    break;
                case TipEveniment.Cultural:
                    rdbCultural.Checked = true;
                    break;
                case TipEveniment.Sportiv:
                    rdbSportiv.Checked = true;
                    break;
                case TipEveniment.Educational:
                    rdbEducational.Checked = true;
                    break;
                case TipEveniment.Caritabil:
                    rdbCaritabil.Checked = true;
                    break;
                case TipEveniment.Politic:
                    rdbPolitic.Checked = true;
                    break;
                case TipEveniment.Religios:
                    rdbReligios.Checked = true;
                    break;
                case TipEveniment.Networking:
                    rdbNetworking.Checked = true;
                    break;
                case TipEveniment.Virtual:
                    rdbVirtual.Checked = true;
                    break;
            }
        }

        private bool DateIntrareValide()
        {
            string denumire = txtDenumire.Text;
            string data = txtData.Text;
            string locatie = txtLocatie.Text;
            string ora = txtOra.Text;
            bool valid = true;

            lblMesajEroare.Text = string.Empty;

            if (string.IsNullOrEmpty(denumire) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(locatie) || string.IsNullOrEmpty(ora))
            {
                lblMesajEroare.Text = "Toate câmpurile trebuie completate!";
                lblMesajEroare.ForeColor = Color.Red;

                if (string.IsNullOrEmpty(denumire))
                    lblDenumire.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(data))
                    lblData.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(locatie))
                    lblLocatie.ForeColor = Color.Red;
                if (string.IsNullOrEmpty(ora))
                    lblOra.ForeColor = Color.Red;

                if (!TipEvenimentEsteSelectat())
                    lblTip.ForeColor = Color.Red;

                valid = false;
            }
            else if (denumire.Length > NRMAXCARACTERE)
            {
                lblMesajEroare.Text = $"Denumirea evenimentului nu poate depăși {NRMAXCARACTERE} caractere!";
                lblMesajEroare.ForeColor = Color.Red;
                valid = false;
            }

            List<Eveniment> evenimenteCuAceeasiDenumire = adminEvenimentef.GetEvenimentDenumire(denumire);
            if (evenimenteCuAceeasiDenumire != null && evenimenteCuAceeasiDenumire.Count > 0)
            {
                lblMesajEroare.Text = "Evenimentul exista deja!";
                lblMesajEroare.ForeColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        private bool TipEvenimentEsteSelectat()  
        {
            return rdbCorporativ.Checked || rdbSocial.Checked || rdbCultural.Checked || rdbSportiv.Checked || rdbEducational.Checked || rdbCaritabil.Checked || rdbPolitic.Checked || rdbReligios.Checked || rdbNetworking.Checked || rdbVirtual.Checked;
        }


        private TipEveniment GetTipEvenimentSelectat()
        {
            if (rdbCorporativ.Checked)
                return TipEveniment.Corporativ;
            if (rdbSocial.Checked)
                return TipEveniment.Social;
            if (rdbCultural.Checked)
                return TipEveniment.Cultural;
            if (rdbSportiv.Checked)
                return TipEveniment.Sportiv;
            if (rdbEducational.Checked)
                return TipEveniment.Educational;
            if (rdbCaritabil.Checked)
                return TipEveniment.Caritabil;
            if (rdbPolitic.Checked)
                return TipEveniment.Politic;
            if (rdbReligios.Checked)
                return TipEveniment.Religios;
            if (rdbNetworking.Checked)
                return TipEveniment.Networking;
            if (rdbVirtual.Checked)
                return TipEveniment.Virtual;

            return TipEveniment.Corporativ;
        }

        private void AfisareEvenimenteInControlListbox(List<Eveniment> evenimente)
        {
            lstAfisare.Items.Clear();
            foreach (Eveniment eveniment in evenimente)
            {
                lstAfisare.Items.Add(eveniment);
            }
        }

        private void AfisareEvenimenteInControlDataGridView(List<Eveniment> evenimente)
        {
            dataGridEvenimente.DataSource = null;
            dataGridEvenimente.DataSource = evenimente.Select(e => new
            {
                e.denumire,
                e.tip,
                e.data,
                e.locatie,
                e.ora
            }).ToList();
        }


        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lstAfisare.SelectedItem != null)
            {
                Eveniment evenimentSelectat = (Eveniment)lstAfisare.SelectedItem;
                adminEvenimentef.StergeEveniment(evenimentSelectat.denumire);

                lblMesajEroare.Text = "Eveniment șters cu succes!";
                lblMesajEroare.ForeColor = Color.Green;

                List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();

                AfisareEvenimenteInControlListbox(evenimente);
                AfisareEvenimenteInControlDataGridView(evenimente);
                AfiseazaEvenimente();
            }
            else
            {
                lblMesajEroare.Text = "Selectați un eveniment din listă pentru a-l șterge.";
                lblMesajEroare.ForeColor = Color.Red;
            }
        }


        private void ResetareControale()
        {
            txtDenumire.Text = txtData.Text = txtLocatie.Text = txtOra.Text = string.Empty;

            rdbCorporativ.Checked = false;
            rdbSocial.Checked = false;
            rdbCultural.Checked = false;
            rdbSportiv.Checked = false;
            rdbEducational.Checked = false;
            rdbCaritabil.Checked = false;
            rdbPolitic.Checked = false;
            rdbReligios.Checked = false;
            rdbNetworking.Checked = false;
            rdbVirtual.Checked = false;

            lblMesajEroare.Text = string.Empty;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }

        private void btnCautareEvenimentDupaLocatie_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareEvenimentDupaLocatie_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }

        private void btnCautareEvenimentData_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareEvenimentData_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }

        private void btnCautareTipEveniment_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareTipEveniment_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }


        private void btnSterge_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnSterge_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }


        private void btnModifica_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnModifica_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;
        }



        private void btnCautareEveniment_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareEveniment_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;


        }

        private void btnCautareData_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareData_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;


        }

        private void btnAdauga_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnAdauga_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;


        }

        private void btnCautareLocatie_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.DarkGreen;
            btn.ForeColor = Color.White;
        }

        private void btnCautareLocatie_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGreen;
            btn.ForeColor = Color.DarkGreen;


        }
    }
}

