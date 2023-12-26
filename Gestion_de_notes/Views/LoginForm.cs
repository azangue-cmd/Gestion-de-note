using Gestion_de_notes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_notes.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administration wokam = new Administration();
            wokam.CreerEtudiant("theo", "franck","3","gl",'M',"23/02/2005");
            MessageBox.Show("bravo tu viens de creer un etudiant ");

        }
    }
}
