using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
namespace Assignment2
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static string ComputeOperation(string firstNum, string secondNum, string operation)
        {
            string result = string.Empty;

            
            if (ValidateNumbers(firstNum, secondNum)) // Goto ValidateNumbers Method
            {
                switch (operation)
                {
                    case "+":
                        result = AddNumbers(firstNum, secondNum); // Goto AddNumbers method
                        break;
                    case "-":
                        result = SubtractTwoNumbers(firstNum, secondNum);// Goto SubtractTwoNumbers method
                        break;
                    case "*":
                        result = MultiplyTwoNumbers(firstNum, secondNum);// Goto MultiplyTwoNumbers method
                        break;
                    case "/":
                        result = DivideTwoNumbers(firstNum, secondNum);// Goto DivideTwoNumbers method
                        break;

                }
            }
            else
            {
                result = "Numbers are invalid";
            }
            return result;
        }

        
        public static bool ValidateNumbers(string number1, string number2)
        {
            bool isValidNumbers = false;        //initialize defaultly as false.
             
            foreach (char c in number1.ToCharArray()) // Check if second number is valid
            {

                if (char.IsDigit(c))
                {
                    isValidNumbers = true;
                }
                else
                {
                    isValidNumbers = false;
                    break;
                }
            }
            if (isValidNumbers)
            {
                foreach (char c in number2.ToCharArray()) // Check if second number is valid
                {
                    if (char.IsDigit(c))
                    {
                        isValidNumbers = true;
                    }
                    else
                    {
                        isValidNumbers = false;
                        break;
                    }
                }
            }
            return isValidNumbers;
        }

        //adding the numbers
        public static string AddNumbers(string a, string b)
        {
            string operationResult = string.Empty;
            StringBuilder sb = new StringBuilder();
            if (a.Length > b.Length)
            {
                b = new string('0', a.Length - b.Length) + b; //Padding the extra length to b
            }
            else if (a.Length < b.Length)
            {
                a = new string('0', b.Length - a.Length) + a; //Padding the extra length to a
            }
            
            int carry = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {

                int sum = 0;
                sum = Convert.ToInt32(a.Substring(i, 1)) + Convert.ToInt32(b.Substring(i, 1)) + carry;
                if (i == 0)
                {
                    if (sum.ToString().Length > 1)
                    {
                        sb.Append(sum.ToString().Substring(1, 1) + sum.ToString().Substring(0, 1));
                    }
                    else
                    {
                        sb.Append(sum.ToString());
                    }


                }
                else if (sum.ToString().Length > 1)
                {
                    carry = Convert.ToInt32(sum.ToString().Substring(0, 1));
                    sb.Append(sum.ToString().Substring(1, 1));
                }
                else
                {
                    carry = 0;
                    sb.Append(sum.ToString());
                }

            }
            operationResult = sb.ToString();
            char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
            return new string(reversedArray);
        }

        //subtracting the numbers
        public static string SubtractTwoNumbers(string a, string b)
        {
            string result = "0";
            StringBuilder sb = new StringBuilder();
            string operationResult = string.Empty;
            bool isNegetiveOperation = false;
            int borrow = 0;
            if (a.Trim().Equals(b.Trim()))
            {
                sb.Append("0");
            }
            else
            {
                if (a.Length > b.Length)
                {
                    b = new string('0', a.Length - b.Length) + b;
                }
                else if (a.Length < b.Length)
                {
                    a = new string('0', b.Length - a.Length) + a;
                    string temp = a;
                    a = b;
                    b = temp;
                    isNegetiveOperation = true;
                }
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    int diff = 0;
                    if (i == 0)
                    {
                        if (Convert.ToInt32(a[i]) - borrow < Convert.ToInt32(b[i]))
                        {
                            diff = 0;
                            borrow = 0;
                        }
                        else
                        {
                            diff = Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
                            borrow = 0;
                        }

                    }
                    else if (Convert.ToInt32(a[i]) - borrow >= Convert.ToInt32(b[i]))
                    {
                        diff = Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
                        borrow = 0;
                    }
                    else
                    {
                        diff = 10 + Convert.ToInt32(a[i]) - borrow - Convert.ToInt32(b[i]);
                        borrow = 1;
                    }

                    if (i == 0 && diff == 0)
                    {
                    }
                    else
                    {
                        sb.Append(diff.ToString());
                    }
                }
            }

            operationResult = sb.ToString();
            char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
            result = new string(reversedArray);
            if (result.Contains("-"))
            {
                result = "-" + result.Replace("-", "");
            }
            if (isNegetiveOperation)
            {
                result = "-" + result;
            }
            return result;

        }

        //multipling the numbers
        public static string MultiplyTwoNumbers(string a, string b)
        {
            string result = string.Empty;
            List<string> lstMultiplyResults = new List<string>();
            string operationResult = string.Empty;
            int counter = 0;
            for (int i = b.Length - 1; i >= 0; i--)
            {
                StringBuilder sb = new StringBuilder();
                int carry = 0;

                if (counter > 0)
                {
                    sb.Append(0.ToString("D" + counter.ToString()));

                }
                for (int j = a.Length - 1; j >= 0; j--)
                {

                    int mul = carry + (Convert.ToInt32(a.Substring(j, 1)) * Convert.ToInt32(b.Substring(i, 1)));
                    if (mul.ToString().Length > 1)
                    {
                        if (j == 0)
                        {
                            sb.Append(mul.ToString().Substring(1, 1) + mul.ToString().Substring(0, 1));
                        }
                        else
                        {
                            carry = Convert.ToInt32(mul.ToString().Substring(0, 1));
                            sb.Append(mul.ToString().Substring(1, 1));
                        }
                    }
                    else
                    {
                        carry = 0;
                        sb.Append(mul);
                    }
                }
                operationResult = sb.ToString();
                char[] reversedArray = operationResult.ToCharArray().Reverse().ToArray();
                lstMultiplyResults.Add(new string(reversedArray));
                counter++;
            }
            result = 0.ToString();
            foreach (string str in lstMultiplyResults)
            {
                result = AddNumbers(result, str);
            }
           
            return result;
        }

        //Dividing the numbers
        public static string DivideTwoNumbers(string a, string b)
        {
            string result = string.Empty;
            try
            {
                int divisor = Convert.ToInt32(b);
                if (divisor > 0)
                {
                    int index = 0;
                    int temp = (int)(a[index] - '0');
                    while (temp < divisor)
                    {
                        temp = temp * 10 + (int)(a[index + 1] - '0');
                        index++;
                    }
                    ++index;

                    while (a.Length > index)
                    {
                        // Store result in answer
                        result += (char)(temp / divisor + '0');

                        // Take next digit of number
                        temp = (temp % divisor) * 10 + (int)(a[index] - '0');
                        index++;
                    }
                    result += (char)(temp / divisor + '0');

                    // If divisor is greater than number
                    if (result.Length == 0)
                        return "0";
                }
                else
                {
                    result = "Enter number greater than 0";
                }       
            }
            catch (Exception exp)
            {
                result = exp.Message;
            }

            return result;
        }

    }
}
