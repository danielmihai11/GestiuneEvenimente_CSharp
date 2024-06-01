using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class ParticipantForm : Form
    {

        IStocareDataEvenimente adminEvenimentef;
        IStocareDataParticipanti adminParticipantif;


        public ParticipantForm()
        {
            InitializeComponent();
            adminEvenimentef = StocareFactory.GetAdministratorStocareEvenimente(); 
            adminParticipantif = StocareFactory.GetAdministratorStocareParticipanti();
            LoadEvenimente(); 



            txtEveniment.TextChanged += TxtEveniment_TextChanged; 
            this.WindowState = FormWindowState.Maximized; 
            lblMesajEroare.Top = dataGridEvenimente.Bottom + 10;
            lblMesajEroare.Left = dataGridEvenimente.Left;
        }

        private void LoadEvenimente()
        {
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimente();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Denumire");
            dataTable.Columns.Add("Data");
            dataTable.Columns.Add("Locatie");
            dataTable.Columns.Add("Ora");
            dataTable.Columns.Add("Tip Eveniment");

            foreach (Eveniment eveniment in evenimente)
            {
                dataTable.Rows.Add(eveniment.denumire, eveniment.data, eveniment.locatie, eveniment.ora, eveniment.tip);
            }

            dataGridEvenimente.DataSource = dataTable;

            
            dataGridEvenimente.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
          
            dataGridEvenimente.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridEvenimente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void TxtEveniment_TextChanged(object sender, EventArgs e)
        {
            string denumireEveniment = txtEveniment.Text;
            if (!EvenimentExista(denumireEveniment))
            {
                lblMesajEroareEveniment.Text = "Evenimentul nu se regăsește în lista de evenimente.";
                lblMesajEroareEveniment.ForeColor = Color.Red;
                lblInscriereReusita.Text = string.Empty;


            }
            else
            {
                lblMesajEroareEveniment.Text = string.Empty;
            }
        }

        private bool EvenimentExista(string denumire)
        {
            foreach (DataGridViewRow row in dataGridEvenimente.Rows)
            {
                if (row.Cells["Denumire"].Value != null && row.Cells["Denumire"].Value.ToString().Equals(denumire, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string varsta = txtVarsta.Text;
            string eveniment = txtEveniment.Text;

            if (string.IsNullOrEmpty(nume) || string.IsNullOrEmpty(prenume) || string.IsNullOrEmpty(varsta) || string.IsNullOrEmpty(eveniment))
            {
                lblMesajEroareEveniment.Text = "Toate câmpurile trebuie completate!";
                lblMesajEroareEveniment.ForeColor = Color.Red;
                lblInscriereReusita.Text = string.Empty;
                lblNume.ForeColor = Color.Red;
                lblPrenume.ForeColor = Color.Red;
                lblVarsta.ForeColor = Color.Red;
                lblEveniment.ForeColor = Color.Red;
                return;
            }

            if (!int.TryParse(varsta, out int varstaInt))
            {
                lblMesajEroareEveniment.Text = "Vârsta introdusă nu este validă!";
                lblMesajEroareEveniment.ForeColor = Color.Red;
                lblInscriereReusita.Text = string.Empty;
                return;
            }

            List<Participant> participanti = adminParticipantif.GetParticipantEveniment(eveniment);
            if (participanti != null && participanti.Any(p => p.nume == nume && p.prenume == prenume))
            {
                lblMesajEroare.Text = "V-ați înscris deja la acest eveniment!";
                lblMesajEroare.ForeColor = Color.Red;
                return;
            }

            SalveazaDateParticipant(nume, prenume, varstaInt, eveniment);
        }

        private void SalveazaDateParticipant(string nume, string prenume, int varsta, string eveniment)
        {
            Participant participant = new Participant(nume, prenume, varsta, eveniment);
            adminParticipantif.AddParticipant(participant);

            lblMesajEroare.Text = $"Înscriere reușită!";
            lblMesajEroare.ForeColor = Color.Green;
        }
        private void btnCautareEvenimentDupaLocatie_Click(object sender, EventArgs e)
        {
            string locatie = txtCautareEvenimentLocatie.Text;
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimentLocatie(locatie);
            if (evenimente.Count == 0)
            {
                lblMesajEroare.Text = $"Nu exista evenimente in aceasta locatie!";
                lblMesajEroare.ForeColor = Color.Red;

            }
            else
            {
                lblMesajEroare.Text = string.Empty;
            }
            PopuleazaDataGridView(evenimente);
        }

        private void btnCautareEvenimentData_Click(object sender, EventArgs e)
        {
            string data = txtBoxCautareEvenimentData.Text;
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimentData(data);
            if (evenimente.Count == 0)
            {
                lblMesajEroare.Text = $"Nu exista un eveniment in aceasta data!";
                lblMesajEroare.ForeColor = Color.Red;

            }
            else
            {
                lblMesajEroare.Text = string.Empty;
            }
            PopuleazaDataGridView(evenimente);
        }

        private void btnCautareTipEveniment_Click(object sender, EventArgs args)
        {
            string tipEveniment = txtCautareEvenimentTip.Text;
            List<Eveniment> evenimente = adminEvenimentef.GetEvenimentTip(tipEveniment);

           
            if (evenimente.Count == 0)
            {
                lblMesajEroare.Text = $"Nu exista un eveniment de acest tip!";
                lblMesajEroare.ForeColor = Color.Red;

            }
            else
            {
                lblMesajEroare.Text = string.Empty;
            }
            PopuleazaDataGridView(evenimente);
        }

        private void PopuleazaDataGridView(List<Eveniment> evenimente)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Denumire");
            dataTable.Columns.Add("Data");
            dataTable.Columns.Add("Locatie");
            dataTable.Columns.Add("Ora");
            dataTable.Columns.Add("Tip Eveniment");

            foreach (Eveniment eveniment in evenimente)
            {
                dataTable.Rows.Add(eveniment.denumire, eveniment.data, eveniment.locatie, eveniment.ora, eveniment.tip);
            }

            dataGridEvenimente.DataSource = dataTable;

            dataGridEvenimente.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            dataGridEvenimente.DefaultCellStyle.ForeColor = Color.Blue;
            dataGridEvenimente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.DarkGreen;
            btnSubmit.ForeColor = Color.White;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.LightGreen;
            btnSubmit.ForeColor = Color.DarkGreen;
        }

        private void btnCautareEvenimentDupaLocatie_MouseEnter(object sender, EventArgs e)
        {
            btnCautareEvenimentDupaLocatie.BackColor = Color.DarkGreen;
            btnCautareEvenimentDupaLocatie.ForeColor = Color.White;
        }

        private void btnCautareEvenimentDupaLocatie_MouseLeave(object sender, EventArgs e)
        {
            btnCautareEvenimentDupaLocatie.BackColor = Color.LightGreen;
            btnCautareEvenimentDupaLocatie.ForeColor = Color.DarkGreen;
        }

        private void btnCautareEvenimentData_MouseEnter(object sender, EventArgs e)
        {
            btnCautareEvenimentData.BackColor = Color.DarkGreen;
            btnCautareEvenimentData.ForeColor = Color.White;
        }

        private void btnCautareEvenimentData_MouseLeave(object sender, EventArgs e)
        {
            btnCautareEvenimentData.BackColor = Color.LightGreen;
            btnCautareEvenimentData.ForeColor = Color.DarkGreen;
        }

        private void btnCautareTipEveniment_MouseEnter(object sender, EventArgs e)
        {
            btnCautareTipEveniment.BackColor = Color.DarkGreen;
            btnCautareTipEveniment.ForeColor = Color.White;
        }

        private void btnCautareTipEveniment_MouseLeave(object sender, EventArgs e)
        {
            btnCautareTipEveniment.BackColor = Color.LightGreen;
            btnCautareTipEveniment.ForeColor = Color.DarkGreen;
        }

    }


}