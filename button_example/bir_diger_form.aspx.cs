using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace button_example
{
    public partial class bir_diger_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string get_method_ile_alinan = Request.QueryString["girilen"];

            if(get_method_ile_alinan != "")
            {
                result.InnerHtml = "Bir önceki sayfadan GET Method ile '" + get_method_ile_alinan + "' degeri geldi";
            }
            else
            {
                Response.Redirect("form1.aspx");
            }
            
        }
    }
}