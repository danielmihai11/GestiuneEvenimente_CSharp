using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;
using System.IO;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form1 : Form
    {
        private Label lblTitlu;
        private Label lblNumeHeader;
        private Label lblPrenumeHeader;
        private Label lblVarstaHeader;
        private Label lblEvenimentHeader;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        public Form1()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisierP"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdministrareMemorieParticipanti_Fisier adminParticipanti = new AdministrareMemorieParticipanti_Fisier(caleCompletaFisier);
            int nrParticipanti = 0;
            Participant[] participanti = adminParticipanti.GetParticipanti(out nrParticipanti);

            this.Size = new Size(800, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Informatii participanti";

            lblTitlu = new Label();
            lblTitlu.Text = "Lista de participanti";
            lblTitlu.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitlu.TextAlign = ContentAlignment.MiddleCenter;
            lblTitlu.Dock = DockStyle.Top;
            lblTitlu.Height = 30;
            lblTitlu.BackColor = Color.LightGray;
            this.Controls.Add(lblTitlu);

            int availableWidth = this.ClientSize.Width / 4;

            lblNumeHeader = new Label();
            lblNumeHeader.Text = "Nume";
            lblNumeHeader.Font = new Font("Arial", 10, FontStyle.Regular);
            lblNumeHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeHeader.Size = new Size(availableWidth, 23);
            lblNumeHeader.Location = new Point(0, lblTitlu.Bottom + 10);
            this.Controls.Add(lblNumeHeader);

            lblPrenumeHeader = new Label();
            lblPrenumeHeader.Text = "Prenume";
            lblPrenumeHeader.Font = new Font("Arial", 10, FontStyle.Regular);
            lblPrenumeHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblPrenumeHeader.Size = new Size(availableWidth, 23);
            lblPrenumeHeader.Location = new Point(availableWidth, lblTitlu.Bottom + 10);
            this.Controls.Add(lblPrenumeHeader);

            lblVarstaHeader = new Label();
            lblVarstaHeader.Text = "Varsta";
            lblVarstaHeader.Font = new Font("Arial", 10, FontStyle.Regular);
            lblVarstaHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblVarstaHeader.Size = new Size(availableWidth, 23);
            lblVarstaHeader.Location = new Point(2 * availableWidth, lblTitlu.Bottom + 10);
            this.Controls.Add(lblVarstaHeader);

            lblEvenimentHeader = new Label();
            lblEvenimentHeader.Text = "Eveniment";
            lblEvenimentHeader.Font = new Font("Arial", 10, FontStyle.Regular);
            lblEvenimentHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblEvenimentHeader.Size = new Size(availableWidth, 23);
            lblEvenimentHeader.Location = new Point(3 * availableWidth, lblTitlu.Bottom + 10);
            this.Controls.Add(lblEvenimentHeader);

            int yPos = lblNumeHeader.Bottom + 10;

            for (int i = 0; i < nrParticipanti; i++)
            {

                Label lblNumeParticipant = new Label();
                lblNumeParticipant.Text = participanti[i].nume;
                lblNumeParticipant.Font = new Font("Arial", 9, FontStyle.Regular);
                lblNumeParticipant.TextAlign = ContentAlignment.MiddleCenter;
                lblNumeParticipant.Size = new Size(availableWidth, 23);
                lblNumeParticipant.Location = new Point(0, yPos);
                this.Controls.Add(lblNumeParticipant);

                Label lblPrenumeParticipant = new Label();
                lblPrenumeParticipant.Text = participanti[i].prenume;
                lblPrenumeParticipant.Font = new Font("Arial", 9, FontStyle.Regular);
                lblPrenumeParticipant.TextAlign = ContentAlignment.MiddleCenter;
                lblPrenumeParticipant.Size = new Size(availableWidth, 23);
                lblPrenumeParticipant.Location = new Point(availableWidth, yPos);
                this.Controls.Add(lblPrenumeParticipant);

                Label lblVarstaParticipant = new Label();
                lblVarstaParticipant.Text = participanti[i].GetVarstaAsString();
                lblVarstaParticipant.Font = new Font("Arial", 9, FontStyle.Regular);
                lblVarstaParticipant.TextAlign = ContentAlignment.MiddleCenter;
                lblVarstaParticipant.Size = new Size(availableWidth, 23);
                lblVarstaParticipant.Location = new Point(2 * availableWidth, yPos);
                lblVarstaParticipant.ForeColor = Color.Black;
                this.Controls.Add(lblVarstaParticipant);

                Label lblEvenimentParticipant = new Label();
                lblEvenimentParticipant.Text = participanti[i].eveniment;
                lblEvenimentParticipant.Font = new Font("Arial", 9, FontStyle.Regular);
                lblEvenimentParticipant.TextAlign = ContentAlignment.MiddleCenter;
                lblEvenimentParticipant.Size = new Size(availableWidth, 23);
                lblEvenimentParticipant.Location = new Point(3 * availableWidth, yPos);
                lblEvenimentParticipant.ForeColor = Color.Black;
                this.Controls.Add(lblEvenimentParticipant);

                yPos += DIMENSIUNE_PAS_Y;
            }
        }
    }
}
