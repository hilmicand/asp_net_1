using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace button_example
{
    public partial class form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user_form.InnerHtml = "<a class='btn btn-primary' href='/bir_diger_form.aspx?girilen=123123123' role='button'>Diger Sayfaya Geç</a>";
        }
    }
}