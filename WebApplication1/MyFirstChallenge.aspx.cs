using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyFirstChallenge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void okButton_Click1(object sender, EventArgs e)

        {
            string age = ageTextBox.Text;
            string money = moneyTextBox.Text;

            string result = "At " + age + " years old, I would have expected you to have more than " + money + " dollars in your pocket.";

            resultLabel.Text = result;


        }

        protected void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}