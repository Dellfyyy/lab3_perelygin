namespace lab3_perelygin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IOperation
        {
            string GetOperationName(); //Название операции
            string GetOperationSign(); //Знак операции
            int Operation(int a, int b); //Выполнение операции
        }

        public class DIV : IOperation
        {
            public string GetOperationName() => "Целочисленное деление";
            public string GetOperationSign() => "DIV";
            public int Operation(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Деление на ноль недопустимо");
                return a / b;
            }
        }

        public class MOD : IOperation
        {
            public string GetOperationName() => "Остаток от деления";

            public string GetOperationSign() => "МОД";

            public int Operation(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Деление на ноль недопустимо");
                return a % b;
            }
        }

        public class NOD : IOperation
        {
            public string GetOperationName() => "Наибольший общий делитель";

            public string GetOperationSign() => "НОД";

            public int Operation(int a, int b)
            {
                while (b != 0) //Алгоритм Евклида для нахождения НОД
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }
        }

        public class NOK : IOperation
        {
            public string GetOperationName() => "Наименьшее общее кратное";

            public string GetOperationSign() => "НОК";

            public int Operation(int a, int b)
            {
                if (a == 0 || b == 0)
                    throw new ArgumentException("НОК не определён для 0");
                return a * b / new MOD().Operation(a, b); //Находим НОК через НОД согласно формуле
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            string operation = comboBox1.Text;
            try {
                switch (operation)
                {
                    case "DIV":
                        DIV resultDIV = new DIV();
                        textBox1.Text = $"Название: {resultDIV.GetOperationName()}\r\n" +
                            $"Знак: {resultDIV.GetOperationSign()}\r\n" +
                            $"Результат: {resultDIV.Operation(a, b)}";
                        break;
                    case "МОД":
                        MOD resultMOD = new MOD();
                        textBox1.Text = $"Название: {resultMOD.GetOperationName()}\r\n" +
                            $"Знак: {resultMOD.GetOperationSign()}\r\n" +
                            $"Результат: {resultMOD.Operation(a, b)}";
                        break;
                    case "НОД":
                        NOD resultNOD = new NOD();
                        textBox1.Text = $"Название: {resultNOD.GetOperationName()}\r\n" +
                            $"Знак: {resultNOD.GetOperationSign()}\r\n" +
                            $"Результат: {resultNOD.Operation(a, b)}";
                        break;
                    case "НОК":
                        NOK resultNOK = new NOK();
                        textBox1.Text = $"Название: {resultNOK.GetOperationName()}\r\n" +
                            $"Знак: {resultNOK.GetOperationSign()}\r\n" +
                            $"Результат: {resultNOK.Operation(a, b)}";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
