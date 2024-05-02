using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelStocareDate;
using LibrarieModele;
using System.Configuration;

namespace InterfataUtilizator_WindowsForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormularParticipanti());
        }
    }
    public class FormularParticipanti : Form
    {
        private Label lbTitlu;
        private Label lbTitlu2;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblVarsta;
        private Label lblEveniment;

        
        private Label lblEroare;

        private Label lblIntroducereNume;
        private TextBox txtIntroducereNume;

        private Label lblIntroducerePrenume;
        private TextBox txtIntroducerePrenume;

        private Label lblIntroducereVarsta;
        private TextBox txtIntroducereVarsta;

        private Label lblIntroducereEveniment;
        private TextBox txtIntroducereEveniment;

        private Button btnAdauga;
        private Button btnRefresh;
        private Label lblSalvare;
        private Label lblRefresh;

        private const int LATIME_CONTROL = 150;
        private const int LUNGIME_CONTROL = 30;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 150;

        AdministrareMemorieParticipanti_Fisier adminParticipanti;
       
        public FormularParticipanti()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisierP"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminParticipanti = new AdministrareMemorieParticipanti_Fisier(caleCompletaFisier);


            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Blue;
            this.Text = "Informatii participanti";

            AfiseazaParticipanti();

            Butoane();


        }
        private void TxtIntroducereNume_TextChanged(object sender, EventArgs e)
        {
            if (txtIntroducereNume.Text.Length > 15)
            {
                lblEroare.Text = "Numele nu poate depăși 15 caractere!";
            }
            else
            {
                lblEroare.Text = ""; // Curăță mesajul de eroare când textul este valid
            }
        }

        private void TxtIntroducerePrenume_TextChanged(object sender, EventArgs e)
        {
            if (txtIntroducerePrenume.Text.Length > 15)
            {
                lblEroare.Text = "Prenumele nu poate depăși 15 caractere!";
            }
            else
            {
                lblEroare.Text = ""; // Curăță mesajul de eroare când textul este valid
            }
        }

        private void TxtIntroducereEveniment_TextChanged(object sender, EventArgs e)
        {
            if (txtIntroducereEveniment.Text.Length > 15)
            {
                lblEroare.Text = "Evenimentul nu poate depăși 15 caractere!";
            }
            else
            {
                lblEroare.Text = ""; // Curăță mesajul de eroare când textul este valid
            }
        }



        private void AfiseazaParticipanti()
        {
            int nrParticipanti = 0;
            Participant[] participanti = adminParticipanti.GetParticipanti(out nrParticipanti);

            lbTitlu2 = new Label();
            lbTitlu2.Width = LATIME_CONTROL;
            lbTitlu2.Height = LUNGIME_CONTROL;
            lbTitlu2.BackColor = Color.LightGray;
            this.Controls.Add(lbTitlu2);

            lbTitlu = new Label();
            lbTitlu.Width = LATIME_CONTROL * 3;
            lbTitlu.Height = LUNGIME_CONTROL;
            lbTitlu.Left = DIMENSIUNE_PAS_X;
            lbTitlu.Text = "Participanti";
            lbTitlu.BackColor = Color.LightGray;
            lbTitlu.ForeColor = Color.Blue;
            this.Controls.Add(lbTitlu);

            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Height = LUNGIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Top = DIMENSIUNE_PAS_Y;
            lblNume.BackColor = Color.LightGray;
            lblNume.ForeColor = Color.Blue;
            this.Controls.Add(lblNume);

            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Height = LUNGIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = DIMENSIUNE_PAS_X;
            lblPrenume.Top = DIMENSIUNE_PAS_Y;
            lblPrenume.BackColor = Color.LightGray;
            lblPrenume.ForeColor = Color.Blue;
            this.Controls.Add(lblPrenume);

            lblVarsta = new Label();
            lblVarsta.Width = LATIME_CONTROL;
            lblVarsta.Height = LUNGIME_CONTROL;
            lblVarsta.Text = "Varsta";
            lblVarsta.Left = DIMENSIUNE_PAS_X * 2;
            lblVarsta.Top = DIMENSIUNE_PAS_Y;
            lblVarsta.BackColor = Color.LightGray;
            lblVarsta.ForeColor = Color.Blue;
            this.Controls.Add(lblVarsta);

            lblEveniment = new Label();
            lblEveniment.Width = LATIME_CONTROL;
            lblEveniment.Height = LUNGIME_CONTROL;
            lblEveniment.Text = "Eveniment";
            lblEveniment.Left = DIMENSIUNE_PAS_X * 3;
            lblEveniment.Top = DIMENSIUNE_PAS_Y;
            lblEveniment.BackColor = Color.LightGray;
            lblEveniment.ForeColor = Color.Blue;
            this.Controls.Add(lblEveniment);



            for (int i = 0; i < nrParticipanti; i++)
            {
                lblNume = new Label();
                lblNume.Width = LATIME_CONTROL;
                lblNume.Height = LUNGIME_CONTROL;
                lblNume.Text = participanti[i].nume;
                lblNume.Top = DIMENSIUNE_PAS_Y * (i + 2);
                lblNume.BackColor = Color.LightGray;
                lblNume.ForeColor = Color.Blue;
                this.Controls.Add(lblNume);

                lblPrenume = new Label();
                lblPrenume.Width = LATIME_CONTROL;
                lblPrenume.Height = LUNGIME_CONTROL;
                lblPrenume.Text = participanti[i].prenume;
                lblPrenume.Left = DIMENSIUNE_PAS_X;
                lblPrenume.Top = DIMENSIUNE_PAS_Y * (i + 2);
                lblPrenume.BackColor = Color.LightGray;
                lblPrenume.ForeColor = Color.Blue;
                this.Controls.Add(lblPrenume);

                lblVarsta = new Label();
                lblVarsta.Width = LATIME_CONTROL;
                lblVarsta.Height = LUNGIME_CONTROL;
                lblVarsta.Text = participanti[i].GetVarstaAsString();
                lblVarsta.Left = DIMENSIUNE_PAS_X * 2;
                lblVarsta.Top = DIMENSIUNE_PAS_Y * (i + 2);
                lblVarsta.BackColor = Color.LightGray;
                lblVarsta.ForeColor = Color.Blue;
                this.Controls.Add(lblVarsta);

                lblEveniment = new Label();
                lblEveniment.Width = LATIME_CONTROL;
                lblEveniment.Height = LUNGIME_CONTROL;
                lblEveniment.Text = participanti[i].eveniment;
                lblEveniment.Left = DIMENSIUNE_PAS_X * 3;
                lblEveniment.Top = DIMENSIUNE_PAS_Y * (i + 2);
                lblEveniment.BackColor = Color.LightGray;
                lblEveniment.ForeColor = Color.Blue;
                this.Controls.Add(lblEveniment);
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            bool allGood = true;
            //Participant participant = new Participant(txtIntroducereNume.Text.ToString(), txtIntroducerePrenume.Text.ToString(),, txtIntroducereEveniment.Text.ToString());
            lblEroare.Text = "";
            if (txtIntroducereNume.Text.ToString() == "" || txtIntroducereNume.Text.ToString() == "!")
            {
                txtIntroducereNume.Text = "!";
                txtIntroducereNume.ForeColor = Color.Blue;
                allGood = false;
            }
            else if (txtIntroducereNume.Text.Length > 15)
            {
                txtIntroducereNume.ForeColor = Color.Red;
                lblIntroducereNume.ForeColor = Color.Red;
                allGood = false;
            }
            else
            {
                txtIntroducereNume.ForeColor = Color.Black;
               
            }

            if (txtIntroducerePrenume.Text.ToString() == "" || txtIntroducerePrenume.Text.ToString() == "!")
            {
                txtIntroducerePrenume.Text = "!";
                txtIntroducerePrenume.ForeColor = Color.Blue;
                allGood = false;
            }
            else if (txtIntroducerePrenume.Text.Length > 15)
            {

                txtIntroducerePrenume.ForeColor = Color.Red;
                lblIntroducerePrenume.ForeColor = Color.Red;
                allGood = false;
            }
            else
            {
                txtIntroducerePrenume.ForeColor = Color.Black;
            }

            int age;
            bool isAgeValid = int.TryParse(txtIntroducereVarsta.Text, out age);
            if (!isAgeValid || txtIntroducereVarsta.Text == "!")
            {
                txtIntroducereVarsta.Text = "!";
                txtIntroducereVarsta.ForeColor = Color.Blue;
                allGood = false;
            }
            else
            {
                txtIntroducereVarsta.ForeColor = Color.Black;
            }
            if (txtIntroducereEveniment.Text.ToString() == "" || txtIntroducereEveniment.Text.ToString() == "!")
            {
                txtIntroducereEveniment.Text = "!";
                txtIntroducereEveniment.ForeColor = Color.Blue;
                allGood = false;
            }
            else if (txtIntroducereEveniment.Text.Length > 15)
            {
                txtIntroducereEveniment.ForeColor = Color.Red;
                lblIntroducereEveniment.ForeColor = Color.Red;
                allGood=false;

            }
            else
            {
                txtIntroducereEveniment.ForeColor = Color.Black;
            }


            if (allGood && isAgeValid)
            {
                Participant participant = new Participant(txtIntroducereNume.Text, txtIntroducerePrenume.Text, age, txtIntroducereEveniment.Text);
                adminParticipanti.AddParticipanti(participant);
                lblSalvare.Text = "Participant adaugat!";
                lblSalvare.ForeColor = Color.Green;
                txtIntroducereNume.Text = "";
                txtIntroducerePrenume.Text = "";
                txtIntroducereVarsta.Text = "";
                txtIntroducereEveniment.Text = "";

            }
            else
            {
                lblSalvare.Text = "Informatii introduse incorect!";
                lblSalvare.ForeColor= Color.Red;
            }

        }

        private void OnButton2Clicked(object sender, EventArgs e)
        {
            AfiseazaParticipanti();

            lblRefresh.Text = "Participanti reincarcati";
        }

        private void Butoane()
        {
            lblIntroducereNume = new Label();
            lblIntroducereNume.Width = LATIME_CONTROL;
            lblIntroducereNume.Height = LUNGIME_CONTROL;
            lblIntroducereNume.Left = DIMENSIUNE_PAS_X * 4;
            lblIntroducereNume.Text = "Nume:";
            lblIntroducereNume.BackColor = Color.LightYellow;
            this.Controls.Add(lblIntroducereNume);

            txtIntroducereNume = new TextBox();
            txtIntroducereNume.Width = LATIME_CONTROL;
            txtIntroducereNume.Height = LUNGIME_CONTROL;
            txtIntroducereNume.Left = DIMENSIUNE_PAS_X * 5;
            this.Controls.Add(txtIntroducereNume);

            txtIntroducereNume.TextChanged += TxtIntroducereNume_TextChanged;



            lblIntroducerePrenume = new Label();
            lblIntroducerePrenume.Width = LATIME_CONTROL;
            lblIntroducerePrenume.Height = LUNGIME_CONTROL;
            lblIntroducerePrenume.Left = DIMENSIUNE_PAS_X * 4;
            lblIntroducerePrenume.Top = DIMENSIUNE_PAS_Y;
            lblIntroducerePrenume.Text = "Prenume:";
            lblIntroducerePrenume.BackColor = Color.LightYellow;
            this.Controls.Add(lblIntroducerePrenume);

            txtIntroducerePrenume = new TextBox();
            txtIntroducerePrenume.Width = LATIME_CONTROL;
            txtIntroducerePrenume.Height = LUNGIME_CONTROL;
            txtIntroducerePrenume.Left = DIMENSIUNE_PAS_X * 5;
            txtIntroducerePrenume.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtIntroducerePrenume);

            txtIntroducerePrenume.TextChanged += TxtIntroducerePrenume_TextChanged;


            lblIntroducereVarsta = new Label();
            lblIntroducereVarsta.Width = LATIME_CONTROL;
            lblIntroducereVarsta.Height = LUNGIME_CONTROL;
            lblIntroducereVarsta.Left = DIMENSIUNE_PAS_X * 4;
            lblIntroducereVarsta.Top = DIMENSIUNE_PAS_Y * 2;
            lblIntroducereVarsta.Text = "Varsta:";
            lblIntroducereVarsta.BackColor = Color.LightYellow;
            this.Controls.Add(lblIntroducereVarsta);

            txtIntroducereVarsta = new TextBox();
            txtIntroducereVarsta.Width = LATIME_CONTROL;
            txtIntroducereVarsta.Height = LUNGIME_CONTROL;
            txtIntroducereVarsta.Left = DIMENSIUNE_PAS_X * 5;
            txtIntroducereVarsta.Top = DIMENSIUNE_PAS_Y * 2;
            this.Controls.Add(txtIntroducereVarsta);

            lblIntroducereEveniment = new Label();
            lblIntroducereEveniment.Width = LATIME_CONTROL;
            lblIntroducereEveniment.Height = LUNGIME_CONTROL;
            lblIntroducereEveniment.Left = DIMENSIUNE_PAS_X * 4;
            lblIntroducereEveniment.Top = DIMENSIUNE_PAS_Y * 3;
            lblIntroducereEveniment.Text = "Eveniment:";
            lblIntroducereEveniment.BackColor = Color.LightYellow;
            this.Controls.Add(lblIntroducereEveniment);


            txtIntroducereEveniment = new TextBox();
            txtIntroducereEveniment.Width = LATIME_CONTROL;
            txtIntroducereEveniment.Height = LUNGIME_CONTROL;
            txtIntroducereEveniment.Left = DIMENSIUNE_PAS_X * 5;
            txtIntroducereEveniment.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(txtIntroducereEveniment);

            txtIntroducereEveniment.TextChanged += TxtIntroducereEveniment_TextChanged;

            lblEroare = new Label();
            lblEroare.AutoSize = true;
            lblEroare.ForeColor = Color.Red; // SeteZ culoarea textului la roșu pentru a indica o eroare
            lblEroare.Location = new Point(10, 450); // PoziționeZ labelul la baza formularului pentru a nu fi suprapus de alte controale
            this.Controls.Add(lblEroare);

            /*lblSalvare = new Label();
            lblSalvare.Width = LATIME_CONTROL;
            lblSalvare.Height = LUNGIME_CONTROL;
            lblSalvare.Left = DIMENSIUNE_PAS_X * 4;
            lblSalvare.Top = DIMENSIUNE_PAS_Y;
            lblSalvare.Text = "";
            lblSalvare.BackColor = Color.LightYellow;
            this.Controls.Add(lblSalvare);*/

            lblSalvare = new Label();
            lblSalvare.AutoSize = true;
            lblSalvare.Location = new Point(10, 470); // Ajustează poziția conform layout-ului tău
            lblSalvare.ForeColor = Color.Green; // Culoarea pentru mesaje de succes
            this.Controls.Add(lblSalvare);

            btnAdauga = new Button();
            btnAdauga.Height = LUNGIME_CONTROL;
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 4, 4 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "&Adauga";

            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            lblRefresh = new Label();
            lblRefresh.Width = LATIME_CONTROL;
            lblRefresh.Height = LUNGIME_CONTROL;
            lblRefresh.Left = DIMENSIUNE_PAS_X * 4;
            lblRefresh.Top = 3 * DIMENSIUNE_PAS_Y ;
            lblRefresh.Text = "";
            lblRefresh.BackColor = Color.LightYellow;
            this.Controls.Add(lblRefresh);

            btnRefresh = new Button();
            btnRefresh.Height = LUNGIME_CONTROL;
            btnRefresh.Width = LATIME_CONTROL * 1;
            btnRefresh.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X * 5, 4 * DIMENSIUNE_PAS_Y);
            btnRefresh.Text = "&Refresh";

            btnRefresh.Click += OnButton2Clicked;
            this.Controls.Add(btnRefresh);
        }

    }
}
