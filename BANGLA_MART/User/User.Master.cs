using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BANGLA_MART.User
{
    public partial class User : System.Web.UI.MasterPage
    {
        //private object pnlSliderUC;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsoluteUri.ToString().Contains("Default.aspx"))
            {
                //load the user control 
                Control sliderUserControl = (Control)Page.LoadControl("SliderUserControl.ascx");
                pnlSlierUC.Controls.Add(sliderUserControl);
            }
        }
    }
}