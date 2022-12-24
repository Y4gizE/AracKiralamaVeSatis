using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// SES DOSYALARINI AÇABİLMEK İÇİN BU SİSTEM KOMUTU ÇAĞIRILMALI...
using System.Media;


namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {}
        static public List<ClassLibraryFW.Araba> Arabalar = new List<ClassLibraryFW.Araba>;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownListMarka.Text == "Ford") 
            {
                ClassLibraryFW.Ford ford = new ClassLibraryFW.Ford
                {

                Model = ModelT.Text.ToString();
                ford.MotorHacmi = int.Parse(MotorTipiT.Text);

                    

                }
            }
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}