using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NobetciEczanem
{
    public partial class anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var list = sehirDl.GetCities();
                dropDownListIl.DataSource = list;
                dropDownListIl.DataTextField = "Ad";
                dropDownListIl.DataValueField = "Ad";
                dropDownListIl.DataBind();

                var liste = IlceDl.getIlceler("Adana");
                dropDownListIlce.DataSource = liste;
                dropDownListIlce.DataTextField = "Ad";
                dropDownListIlce.DataValueField = "Ad";
                dropDownListIlce.DataBind();
            }
        }
        protected void dropDownListIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropDownListIlce.Items.Clear();
            var ilAd = dropDownListIl.SelectedValue;
            var list = IlceDl.getIlceler(ilAd);
            dropDownListIlce.DataSource = list;
            dropDownListIlce.DataBind();
        }

    }
}