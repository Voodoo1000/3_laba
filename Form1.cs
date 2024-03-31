namespace _3_laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Установка ComboBox только для выбора элементов из списка
            cmbOperation.DropDownStyle = ComboBoxStyle.DropDownList;

            // Установка текстовых полей только для чтения
            txtLengthA.ReadOnly = true;
            txtLengthB.ReadOnly = true;
            txtResult.ReadOnly = true;
        }
        // Метод для выполнения расчетов
        private void Calculate()
        {
            try
            {
                // Получение значений компонентов из текстовых полей
                var a_x = double.Parse(txtVectorA_x.Text);
                var a_y = double.Parse(txtVectorA_y.Text);
                var a_z = double.Parse(txtVectorA_z.Text);
                var b_x = double.Parse(txtVectorB_x.Text);
                var b_y = double.Parse(txtVectorB_y.Text);
                var b_z = double.Parse(txtVectorB_z.Text);

                // Создание векторов из введенных значений
                var vectorA = new Vector(a_x, a_y, a_z);
                var vectorB = new Vector(b_x, b_y, b_z);

                // Переменная для хранения результата операции
                Vector operationVectors = new Vector(0, 0, 0);

                // Выполнение операции в зависимости от выбранного элемента в ComboBox
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

                // Вычисление длин векторов и вывод результатов
                double lengthVectorA = Vector.Length(vectorA);
                double lengthVectorB = Vector.Length(vectorB);

                txtLengthA.Text = Convert.ToString(lengthVectorA);
                txtLengthB.Text = Convert.ToString(lengthVectorB);
            }
            catch (FormatException)
            {
                // Если произошла ошибка, очищаем текстовые поля и выводим сообщение в диалоговом окне
                txtVectorA_x.Text = "";
                txtVectorA_y.Text = "";
                txtVectorA_z.Text = "";
                txtVectorB_x.Text = "";
                txtVectorB_y.Text = "";
                txtVectorB_z.Text = "";

                MessageBox.Show("Ошибка: неверный формат ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события изменения значений в компонентах
        private void OnValueChanged(object sender, EventArgs e)
        {
            Calculate(); // Вызываем метод Calculate для выполнения расчетов при изменении значений в компонентах
        }
    }
}
