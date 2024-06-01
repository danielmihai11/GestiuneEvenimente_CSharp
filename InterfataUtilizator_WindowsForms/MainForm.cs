using System;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnParticipant.Click += new EventHandler(this.BtnParticipant_Click);
            btnAdministrator.Click += new EventHandler(this.BtnAdministrator_Click);
        }

        private void BtnParticipant_Click(object sender, EventArgs e)
        {
            ParticipantForm participantForm = new ParticipantForm();
            participantForm.Show();
        }

        private void BtnAdministrator_Click(object sender, EventArgs e)
        {
            AdministratorForm adminForm = new AdministratorForm();
            adminForm.WindowState = FormWindowState.Maximized;
            adminForm.Show();
        }

        private void lblTitlu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
