using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void UyeGiris_Click(object sender, EventArgs e)
        {
            string Kadi;
            string parola;
            Kadi = kgiris.Text.ToString();
            parola = pparola.Text.ToString();
            
            if(Kadi == "Ege" && parola == "123")
            {
                
                Response.Redirect("WebForm2.aspx");
                
            }

        }

    }
}