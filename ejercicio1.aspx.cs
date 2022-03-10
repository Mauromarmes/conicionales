using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio1
{
    public partial class ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cnllanta, vlrllanta, vlrmayor;
            cnllanta = Convert.ToInt16(txtprecio.Text);
            vlrllanta = 800;
            vlrmayor = 700;
            if (cnllanta < 5)
            {
                lblvlrllanta.Text = "el valor de la llanta " + vlrllanta;

            }
            else 
            {
                lblvlrllanta.Text = "el valor de la llanta " + vlrmayor;
            }
                
            
        }
    }
}