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
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);

                var vectorA = new Vector(a_x, a_y);
                var vectorB = new Vector(b_x, b_y);

                var sumVectors = vectorA + vectorB;

                double lengthVectorA = Math.Round(Math.Sqrt(Math.Pow(vectorA.x, 2) + Math.Pow(vectorA.y, 2)), 4);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
                txtResult.Text = sumVectors.Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void txtVectorA_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);

                var vectorA = new Vector(a_x, a_y);
                var vectorB = new Vector(b_x, b_y);

                var sumVectors = vectorA + vectorB;

                double lengthVectorA = Math.Round(Math.Sqrt(Math.Pow(vectorA.x, 2) + Math.Pow(vectorA.y, 2)), 4);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
                txtResult.Text = sumVectors.Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void txtVectorB_x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);

                var vectorA = new Vector(a_x, a_y);
                var vectorB = new Vector(b_x, b_y);

                var sumVectors = vectorA + vectorB;

                double lengthVectorB = Math.Round(Math.Sqrt(Math.Pow(vectorB.x, 2) + Math.Pow(vectorB.y, 2)), 4);

                txtLengthB.Text = Convert.ToString(lengthVectorB);
                txtResult.Text = sumVectors.Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void txtVectorB_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);

                var vectorA = new Vector(a_x, a_y);
                var vectorB = new Vector(b_x, b_y);

                var sumVectors = vectorA + vectorB;

                double lengthVectorB = Math.Round(Math.Sqrt(Math.Pow(vectorB.x, 2) + Math.Pow(vectorB.y, 2)), 4);

                txtLengthB.Text = Convert.ToString(lengthVectorB);
                txtResult.Text = sumVectors.Verbose();
            }
            catch (FormatException)
            {

            }
        }
    }
}
