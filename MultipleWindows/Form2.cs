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
    public partial class Form2 : Form
    {
        Form call;
        public Form2(Form lastForm)
        {
            InitializeComponent();
            call = lastForm;
        }

        private void btnGoMainForm_Click(object sender, EventArgs e)
        {
            call.Show();
            this.Close();
        }

        private void btnGoForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(call);
            form1.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            call.Close();
        }
    }
}
