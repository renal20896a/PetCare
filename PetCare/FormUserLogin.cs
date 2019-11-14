using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void Label_Back_Click(object sender, EventArgs e)
        {
            Form_Login log = new Form_Login();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }
    }
}
