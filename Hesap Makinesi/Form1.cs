using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class HesapMakinesi : Form
    {

        public bool err = false;

        private void ResetScreen()
        {
            mainScreen.Text = string.Empty;
        }

        private string GetCalculation()
        {
            string calculation = mainScreen.Text;
            string[] parts = calculation.Split(new string[] { " " }, StringSplitOptions.None);
            float parseOutput;
            int currentIndex = 0;
            float result = 0f;
            try
            {
                result = float.Parse(parts[0], NumberStyles.Any, CultureInfo.InvariantCulture);
            }
            catch
            {
                return "";
            }
            foreach (String str in parts)
            {
                if (float.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out parseOutput)) { }

                else if (str == "+" || str == "-" || str == "x" || str == "÷")
                {
                    try
                    {
                        float secondNumber = float.Parse(parts[currentIndex + 1], NumberStyles.Any, CultureInfo.InvariantCulture);
                        switch (str)
                        {
                            case "+":
                                result += secondNumber; break;

                            case "-":
                                result -= secondNumber; break;

                            case "x":
                                result *= secondNumber; break;

                            case "÷":
                                result /= secondNumber; break;
                        }

                    }
                    catch
                    {
                        err = true;
                        MessageBox.Show("Hatalı giriş yaptınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }

                currentIndex++;
            }
            return result.ToString();
        }

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void AnyButtonClick(object sender, EventArgs e)
        {
            int output;
            string pressedButtonText = (sender as Button).Text;
            if (Int32.TryParse(pressedButtonText, out output))
            {
                mainScreen.Text += output.ToString();
            }
            else if(pressedButtonText == "(" || pressedButtonText == ")" || pressedButtonText == ".")
            {
                mainScreen.Text += pressedButtonText;
            }
            else if(pressedButtonText == "÷" || pressedButtonText == "x" || pressedButtonText == "+" || pressedButtonText == "-")
            {
                mainScreen.Text += String.Format(" {0} ", pressedButtonText);
            }
            else
            {
                switch (pressedButtonText)
                {
                    case "AC":
                        ResetScreen();
                        break;

                    case "⏎":
                        try
                        {
                            if(mainScreen.Text.Substring(mainScreen.Text.Length - 1, 1) != " ")
                                mainScreen.Text = mainScreen.Text.Substring(0, mainScreen.Text.Length - 1);
                            else
                                mainScreen.Text = mainScreen.Text.Substring(0, mainScreen.Text.Length - 3);
                        }
                        catch{ }
                        break;

                    case "=":
                        string calculation = GetCalculation();
                        if (!err)
                        {
                            PrevScreen.Text = mainScreen.Text;
                            mainScreen.Text = calculation;
                        }
                        err = false;
                        break;
                }
            }
        }

    }
}

        //private string[] GetOperations(string[] parts)
        //{
        //    string[] queue = new string[parts.Length/2];
        //    int i = 0;
        //    foreach (String str in parts)
        //    {
        //        if (str == "+" || str == "-" || str == "*" || str == "/")
        //        {
        //            queue.SetValue(str, i);
        //            i++;
        //        }
        //    }
        //    return queue;
        //}

        //private string[] DoPriority(string[] parts)
        //{
        //    string[] queue = GetOperations(parts);
        //    int length = parts.Length - queue.Length;
        //    if(parts.Length > 3)
        //    {
        //        int priority_count = 0;
        //        int[] priority_index = new int[queue.Length];
        //        int i = 0;
        //        foreach (String str in parts)
        //        {
        //            if(str == "*" || str == "/")
        //            {
        //                priority_index.SetValue(i, priority_count);
        //                priority_count++;
        //            }
        //            i++;
        //        }
            
        //        foreach (Int32 index in priority_index)
        //        {
        //            if(index != 0)
        //            {
        //                string calculatedPriority = ApplyCalculation(String.Format("{0},{1},{2}", parts[index], parts[index-1], parts[index+1])).ToString();
        //                parts.SetValue(calculatedPriority, index - 1);
        //                int loop = parts.Length - (index + 1);
        //                for (int a = index; a < loop; a++)
        //                {
        //                    parts.SetValue(parts[a + 2], a);
        //                    parts.SetValue("", a + 2);
        //                }
                      
        //            }
        //        }
        //    }

        //    return parts;
        //}