namespace Area
{
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double area;
            eprInput.Clear();
            try
            {
                if (rbtRectangle.Checked == true)
                {                    
                    area = double.Parse(txtBase.Text) * double.Parse(txtHeight.Text);
                    txtArea.Text = area.ToString();   
                }
                else if (rbtTriangle.Checked == true)
                {
                    area = (double.Parse(txtBase.Text) * double.Parse(txtHeight.Text)) / 2;
                    txtArea.Text = area.ToString();
                }
                else if (rbtCircle.Checked == true)
                {                                                   
                    area = Math.PI * Math.Pow(double.Parse(txtRadius.Text), 2);
                    txtArea.Text = area.ToString();                                
                }              
            }
            catch
            {
                eprInput.SetError(btnCalculate, "There was an input error. Check the numbers and try again");
            }
        }

        private void rbtRectangle_CheckedChanged(object sender, EventArgs e)            
        {
            txtArea.Clear();  eprInput.Clear(); 
            txtBase.Enabled = true; txtBase.Clear();
            txtHeight.Enabled = true; txtHeight.Clear();
            txtRadius.Enabled = false; txtRadius.Clear();

        }

        private void rbtTriangle_CheckedChanged(object sender, EventArgs e)
        {
            txtArea.Clear(); eprInput.Clear();
            txtBase.Enabled = true; txtBase.Clear();
            txtHeight.Enabled = true; txtHeight.Clear();
            txtRadius.Enabled = false; txtRadius.Clear();
        }

        private void rbtCircle_CheckedChanged(object sender, EventArgs e)
        {
            txtArea.Clear(); eprInput.Clear();
            txtBase.Enabled = false; txtBase.Clear();
            txtHeight.Enabled = false; txtHeight.Clear();
            txtRadius.Enabled = true; txtRadius.Clear();
        }
    }
}