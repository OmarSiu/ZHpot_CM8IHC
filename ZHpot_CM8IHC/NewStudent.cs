using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZHpot_CM8IHC
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxnev_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxnev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxnev, "nem lehet üres");
            }
        }

        private void textBoxnev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxnev, string.Empty);
        }

        private void textBoxneptun_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[A-z0-9]{6}$");

            if (!regex.IsMatch(textBoxneptun.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxneptun, "6 betű vagy szám");
            }
        }

        private void textBoxneptun_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxneptun, string.Empty);
        }
    }
}
