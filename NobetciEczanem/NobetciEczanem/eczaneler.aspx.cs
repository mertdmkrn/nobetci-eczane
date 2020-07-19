using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NobetciEczanem
{
    public partial class eczaneler : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string ilValue = Request.Form["ilfield"];
            string ilceValue = Request.Form["ilcefield"];
            if (ilceValue != null && ilValue != null)
            {
                ililce.InnerHtml = ilValue + " ili " + ilceValue + " ilçesindeki Nöbetçi Eczaneler";
                List<Eczane> eczaneler = CreateObject();
                foreach (Eczane ec in eczaneler)
                {
                    ecz.InnerHtml += "<div class=\"eczane\">" + "\n"
                                      + "<div class=\"bilgi\">" + "\n"
                                          + "<p class=\"ad\">" + ec.ad + "</p>" + "\n"
                                          + "<p class=\"ilce\">" + ec.ilce + "</p>" + "\n"
                                          + "<p class=\"adres\">" + ec.adres + "</p>" + "\n"
                                          + "<p class=\"tel\">" + ec.tel + "</p>" + "\n"
                                      + "</div>" + "\n"
                                      + "<div class=\"harita\">" + "\n"
                                      + "<p>" + ec.loc + "</p>" + "\n"
                                      + "</div>" + "\n"
                                      + "</div>";
                }
            }
            if (!Page.IsPostBack)
            {
                var list = sehirDl.GetCities();
                dropDownListIl.DataSource = list;
                dropDownListIl.DataTextField = "Ad";
                dropDownListIl.DataValueField = "Ad";
                dropDownListIl.DataBind();

                var liste = IlceDl.getIlceler(ilValue);
                dropDownListIlce.DataSource = liste;
                dropDownListIlce.DataTextField = "Ad";
                dropDownListIlce.DataValueField = "Ad";
                dropDownListIlce.DataBind();
                dropDownListIl.SelectedValue = ilValue;
                dropDownListIlce.SelectedValue = ilceValue;
            }


        }
        public List<Eczane> CreateObject()
        {
            string ilValue = Request.Form["ilfield"];
            string ilceValue = Request.Form["ilcefield"];
            var client = new RestClient("https://api.collectapi.com/health/dutyPharmacy");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            anasayfa a = new anasayfa();
            request.AddParameter("ilce", ilceValue);
            request.AddParameter("il", ilValue);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("authorization", "apikey 3iEXUTbjcE961SU67QFg7h:0EIpw6NhSatP1v8qkzIdqr");
            IRestResponse response = client.Execute(request);
            List<Eczane> eczaneler = new List<Eczane>();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var myResult = JsonConvert.DeserializeObject<EczaneObject>(response.Content);
                DataTable table = myResult.result;
                foreach (DataRow row in table.Rows)
                {
                    var eczane = new Eczane()
                    {
                        ad = (string)row["name"],
                        ilce = (string)row["dist"],
                        adres = (string)row["address"],
                        tel = (string)row["phone"],
                        loc = (string)row["loc"],
                    };
                    eczaneler.Add(eczane);
                }
            }
            return eczaneler;

        }
        protected void dropDownListIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dropDownListIlce.Items.Clear();
            var ilAd = dropDownListIl.SelectedValue;
            var list = IlceDl.getIlceler(ilAd);
            dropDownListIlce.DataSource = list;
            dropDownListIlce.DataBind();
        }

        public class Eczane
        {
            public string ad { get; set; }
            public string ilce { get; set; }
            public string adres { get; set; }
            public string tel { get; set; }
            public string loc { get; set; }

        }
        public class EczaneObject
        {
            public Boolean success { get; set; }
            public DataTable result { get; set; }
        }
    }
}