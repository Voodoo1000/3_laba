namespace _3_laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtVectorA_x_TextChanged(object sender, EventArgs e)
        {
            var a_x = double.Parse(txtVectorA_x.Text);
            var a_y = double.Parse(txtVectorA_y.Text);
            var b_x = double.Parse(txtVectorB_x.Text);
            var b_y = double.Parse(txtVectorB_y.Text);
        }
    }
}
