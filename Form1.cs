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
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                txtLengthA.Text = Convert.ToString(lengthVectorA);
                
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
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
            }
            catch (FormatException)
            {

            }
        }

        private void txtVectorA_z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
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
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthB.Text = Convert.ToString(lengthVectorB);
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
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthB.Text = Convert.ToString(lengthVectorB);
            }
            catch (FormatException)
            {

            }
        }

        private void txtVectorB_z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                Vector operationVectors = new Vector(0, 0, 0);

                switch (cmbOperation.Text)
                {
                    case "Сложение":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Вычитание":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "Скалярное произведение":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "Векторное произведение":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthB.Text = Convert.ToString(lengthVectorB);
            }
            catch (FormatException)
            {

            }
        }
    }
}
