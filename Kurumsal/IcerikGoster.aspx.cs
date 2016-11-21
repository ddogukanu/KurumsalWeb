using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class IcerikGoster : System.Web.UI.Page
    {
        public string baslik = "";
        public string icerik = "";

        //public Icerik Icerik = new Icerik();
        protected void Page_Load(object sender, EventArgs e)
        {
            //IcerikGoster.aspx?ID=1

            string gelenid = Request.QueryString["ID"];
            if (string.IsNullOrEmpty(gelenid))
            {   //bir yazı seçilmemişse
                baslik = "İçerik bulunamadı";
                icerik = "ID parametresini göndermediğiniz için hangi içeriği göstereceğimizi bilmiyoruz";
            }
            else {
                //idsi belli olan yazının detayı
                int id = Convert.ToInt32(gelenid);
                KurumsalContext ctx = new KurumsalContext();
                var yazi = ctx.Icerikler.Find(id);
                baslik = yazi.Baslik;
                icerik = yazi.Makale;
            }
        }
    }
}