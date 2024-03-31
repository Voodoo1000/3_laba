namespace _3_laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ��������� ComboBox ������ ��� ������ ��������� �� ������
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;

            // ��������� ��������� ����� ������ ��� ������
            txtLengthA.ReadOnly = true;
            txtLengthB.ReadOnly = true;
            txtResult.ReadOnly = true;
        }
        // ����� ��� ���������� ��������
        private void Calculate()
        {
            try
            {
                // ��������� �������� ����������� �� ��������� �����
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                // �������� �������� �� ��������� ��������
                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                // ���������� ��� �������� ���������� ��������
                Vector operationVectors = new Vector(0, 0, 0);

                // ���������� �������� � ����������� �� ���������� �������� � ComboBox
                switch (cmbOperation.Text)
                {
                    case "��������":
                        operationVectors = vectorA + vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "���������":
                        operationVectors = vectorA - vectorB;
                        txtResult.Text = operationVectors.Verbose();
                        break;
                    case "��������� ������������":
                        double scalarProd = Vector.ScalarProd(vectorA, vectorB);
                        txtResult.Text = Convert.ToString(scalarProd);
                        break;
                    case "��������� ������������":
                        txtResult.Text = Vector.VectorProd(vectorA, vectorB);
                        break;
                    default:
                        operationVectors = new Vector(0, 0, 0);
                        txtResult.Text = operationVectors.Verbose();
                        break;
                }

                // ���������� ���� �������� � ����� �����������
                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
                txtLengthB.Text = Convert.ToString(lengthVectorB);
            }
            catch (FormatException)
            {
                // ���� ��������� ������, ������� ��������� ���� � ������� ��������� � ���������� ����
                txtVectorA_x.Text = "";
                txtVectorA_y.Text = "";
                txtVectorA_z.Text = "";
                txtVectorB_x.Text = "";
                txtVectorB_y.Text = "";
                txtVectorB_z.Text = "";

                MessageBox.Show("������: �������� ������ �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ���������� ������� ��������� �������� � �����������
        private void OnValueChanged(object sender, EventArgs e)
        {
            Calculate(); // �������� ����� Calculate ��� ���������� �������� ��� ��������� �������� � �����������
        }
    }
}
