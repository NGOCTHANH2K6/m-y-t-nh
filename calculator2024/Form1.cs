using System;
using System.Linq;
using System.Windows.Forms;

namespace calculator2024
{
    public partial class Form1 : Form
    {
        private string urrentOperator;
        private double firstOperand = 0; // Toán hạng thứ nhất
        private double secondOperand = 0; // Toán hạng thứ hai
        private string currentOperator = ""; // Toán tử hiện tại
        private bool isOperatorClicked = false; // Đánh dấu toán tử đã được nhấn
        private string history = ""; // Lưu lịch sử phép tính

        public Form1()
        {
            InitializeComponent();
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_old.Text = "";
            lbl_Result.Text = "0";
        }

        private void click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null) return;

            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/")
            {
                // Xử lý khi nhấn nút toán tử
                currentOperator = btn.Text;
                firstOperand = double.Parse(lbl_Result.Text); // Lấy toán hạng thứ nhất
                lbl_old.Text = $"{firstOperand} {currentOperator}"; // Hiển thị toán hạng đầu và toán tử
                lbl_Result.Text = "0"; // Đặt lại lbl_Result về 0 cho toán hạng thứ hai
                isOperatorClicked = true;
            }
            else if (btn.Text == "=")
            {
                // Thực hiện phép tính khi nhấn "="
                secondOperand = double.Parse(lbl_Result.Text); // Lấy toán hạng thứ hai
                double result = PerformCalculation(firstOperand, secondOperand, currentOperator); // Thực hiện phép tính

                // Cập nhật lịch sử phép tính
                history += $"{firstOperand} {currentOperator} {secondOperand} = {result}\n";
                lbl_old.Text = history; // Cập nhật lịch sử lên lbl_old
                lbl_Result.Text = result.ToString(); // Hiển thị kết quả trên lbl_Result

                isOperatorClicked = false;
            }
            else if (btn.Text == "C")
            {
                // Reset toàn bộ
                lbl_old.Text = "";
                lbl_Result.Text = "0";
                firstOperand = 0;
                secondOperand = 0;
                currentOperator = "";
                isOperatorClicked = false;
                history = "";
            }
            else
            {
                // Xử lý khi nhấn nút số
                if (lbl_Result.Text == "0" || isOperatorClicked)
                {
                    lbl_Result.Text = btn.Text; // Hiển thị số vừa nhập
                    isOperatorClicked = false;
                }
                else
                {
                    lbl_Result.Text += btn.Text; // Ghép số vào lbl_Result
                }
            }
        }

        private double PerformCalculation(double first, double second, string op)
        {
            switch (op)
            {
                case "+":
                    return first + second;  
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return second != 0 ? first / second : 0; // Xử lý chia cho 0
                default:
                    return 0;
            }
        }

        private void lbl_old_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Result_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbl_old.Text = "";
            lbl_Result.Text = "0";
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = "";
            isOperatorClicked = false;
            history = "";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {

        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            currentOperator = "%";
            firstOperand = double.Parse(lbl_Result.Text);
            lbl_old.Text = $"{firstOperand} {currentOperator}";
            lbl_Result.Text = "0";
            isOperatorClicked = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lbl_Result.Text);
            double result = value * value;
            lbl_old.Text = $"{value}² = {result}";
            lbl_Result.Text = result.ToString();
            history += $"{value}² = {result}\n";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lbl_Result.Text);
            if (value >= 0)
            {
                double result = Math.Sqrt(value);
                lbl_old.Text = $"√{value} = {result}";
                lbl_Result.Text = result.ToString();
                history += $"√{value} = {result}\n";
            }
            else
            {
                MessageBox.Show("Không thể tính căn bậc hai của số âm!", "Lỗi");
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lbl_Result.Text);
            if (value != 0)
            {
                double result = 1 / value;
                lbl_old.Text = $"1/{value} = {result}";
                lbl_Result.Text = result.ToString();
                history += $"1/{value} = {result}\n";
            }
            else
            {
                MessageBox.Show("Không thể chia cho 0!", "Lỗi");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            currentOperator = "-"; // Gán toán tử trừ
            firstOperand = double.Parse(lbl_Result.Text); // Lấy toán hạng thứ nhất từ lbl_Result
            lbl_old.Text = $"{firstOperand} {currentOperator}"; // Hiển thị phép tính đang thực hiện
            lbl_Result.Text = "0"; // Reset lbl_Result để nhập toán hạng thứ hai
            isOperatorClicked = true; // Đánh dấu đã nhấn toán tử
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!lbl_Result.Text.Contains("."))
            {
                lbl_Result.Text += ".";
            }
        }
        private void btnNegate_Click(object sender, EventArgs e)
        {
            double value = double.Parse(lbl_Result.Text);
            value = -value;
            lbl_Result.Text = value.ToString();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = history.Split('\n').LastOrDefault(x => x.Contains("="))?.Split('=')[1].Trim();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e) => AppendNumber("0");
        private void btn1_Click(object sender, EventArgs e) => AppendNumber("1");
        private void btn2_Click(object sender, EventArgs e) => AppendNumber("2");
        private void btn3_Click(object sender, EventArgs e) => AppendNumber("3");
        private void btn4_Click(object sender, EventArgs e) => AppendNumber("4");
        private void btn5_Click(object sender, EventArgs e) => AppendNumber("5");
        private void btn6_Click(object sender, EventArgs e) => AppendNumber("6");
        private void btn7_Click(object sender, EventArgs e) => AppendNumber("7");
        private void btn8_Click(object sender, EventArgs e) => AppendNumber("8");
        private void btn9_Click(object sender, EventArgs e) => AppendNumber("9");

        private void AppendNumber(string number)
        {
            if (lbl_Result.Text == "0" || isOperatorClicked)
            {
                lbl_Result.Text = number;
                isOperatorClicked = false;
            }
            else
            {
                lbl_Result.Text += number;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            urrentOperator = "+"; // Gán toán tử cộng
            firstOperand = double.Parse(lbl_Result.Text); // Lấy toán hạng thứ nhất từ lbl_Result
            lbl_old.Text = $"{firstOperand} {currentOperator}"; // Hiển thị phép tính đang thực hiện
            lbl_Result.Text = "0"; // Reset lbl_Result để nhập toán hạng thứ hai
            isOperatorClicked = true; // Đánh dấu đã nhấn toán tử
        }
    }
}
