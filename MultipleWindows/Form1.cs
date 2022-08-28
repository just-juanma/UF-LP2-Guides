using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleWindows
{
    public partial class Form1 : Form
    {
        Form call;
        public Form1(Form lastForm)
        {
            InitializeComponent();
            call = lastForm;
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            call.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            call.Close();
        }

        private void btnGoForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(call);
            form2.ShowDialog();
            this.Close();
        }
    }
}
