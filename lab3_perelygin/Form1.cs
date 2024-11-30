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
            string GetOperationName(); //�������� ��������
            string GetOperationSign(); //���� ��������
            int Operation(int a, int b); //���������� ��������
        }

        public class DIV : IOperation
        {
            public string GetOperationName() => "������������� �������";
            public string GetOperationSign() => "DIV";
            public int Operation(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("������� �� ���� �����������");
                return a / b;
            }
        }

        public class MOD : IOperation
        {
            public string GetOperationName() => "������� �� �������";

            public string GetOperationSign() => "���";

            public int Operation(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("������� �� ���� �����������");
                return a % b;
            }
        }

        public class NOD : IOperation
        {
            public string GetOperationName() => "���������� ����� ��������";

            public string GetOperationSign() => "���";

            public int Operation(int a, int b)
            {
                while (b != 0) //�������� ������� ��� ���������� ���
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
            public string GetOperationName() => "���������� ����� �������";

            public string GetOperationSign() => "���";

            public int Operation(int a, int b)
            {
                if (a == 0 || b == 0)
                    throw new ArgumentException("��� �� �������� ��� 0");
                return a * b / new MOD().Operation(a, b); //������� ��� ����� ��� �������� �������
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
                        textBox1.Text = $"��������: {resultDIV.GetOperationName()}\r\n" +
                            $"����: {resultDIV.GetOperationSign()}\r\n" +
                            $"���������: {resultDIV.Operation(a, b)}";
                        break;
                    case "���":
                        MOD resultMOD = new MOD();
                        textBox1.Text = $"��������: {resultMOD.GetOperationName()}\r\n" +
                            $"����: {resultMOD.GetOperationSign()}\r\n" +
                            $"���������: {resultMOD.Operation(a, b)}";
                        break;
                    case "���":
                        NOD resultNOD = new NOD();
                        textBox1.Text = $"��������: {resultNOD.GetOperationName()}\r\n" +
                            $"����: {resultNOD.GetOperationSign()}\r\n" +
                            $"���������: {resultNOD.Operation(a, b)}";
                        break;
                    case "���":
                        NOK resultNOK = new NOK();
                        textBox1.Text = $"��������: {resultNOK.GetOperationName()}\r\n" +
                            $"����: {resultNOK.GetOperationSign()}\r\n" +
                            $"���������: {resultNOK.Operation(a, b)}";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
