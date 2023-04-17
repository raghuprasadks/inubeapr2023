using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspdotnetbasics
{
    public partial class SimpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(TextBoxFN.Text);
            string oper = TextBoxOper.Text;
            int secondNumber = Convert.ToInt32(TextBoxSN.Text);

            int result = 0;
            if (oper.Equals("+"))
                result = firstNumber + secondNumber;
            else if (oper.Equals("-"))
                result = firstNumber - secondNumber;
            LabelResult.Text = result.ToString();







        }
    }
}