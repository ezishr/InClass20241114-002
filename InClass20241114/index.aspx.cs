using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20241114
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Only run this code if it's not a post back
            {
                // How can we run this code only 1 time
                // This method runs when the page is loaded into a browser window
                // Add a pizza company to the list box

                lbPizzaCompanies.Items.Add("LaRosa's");

                // Add a few more items to the list box\
                lbPizzaCompanies.Items.Add("Grammas");
                lbPizzaCompanies.Items.Add("Adriatico's");

                cblIngredients.Items.Add("Tomato");
                cblIngredients.Items.Add("Cheese");
                cblIngredients.Items.Add("Onion");
                cblIngredients.Items.Add("Bell Pepper");
            }

        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            // We call this an "event handler"
            // This code runs when the cmdSelectPizzaCompany button is clicked
            // Write currently selected pizza company into the label

            lblSelectedPizzaCompany.Text = lbPizzaCompanies.SelectedItem.ToString();
        }
    }
}