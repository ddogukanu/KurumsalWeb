using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class bizeulasin : System.Web.UI.Page
    {
        public string sonuc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    KurumsalContext ctx = new KurumsalContext();
                    Iletisim i = new Iletisim();
                    i.AdSoyad = Request.Form["adsoyad"];
                    i.Telefon = Request.Form["telefon"];
                    i.Mesaj = Request.Form["mesaj"];
                    ctx.Iletisim.Add(i);
                    ctx.SaveChanges();
                    sonuc = "Başarıyla eklendi";
                }
                catch { sonuc = "Bir hata oluştu"; }
            }
        }
    }

}