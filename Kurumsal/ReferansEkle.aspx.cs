using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class ReferansEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                KurumsalContext ctx = new KurumsalContext();
                Referans r = new Referans();
                r.AdSoyad = Request.Form["adsoyad"]; //name i adsoyad olan inputa yazılan buraya gelir.
                r.Mesaj = Request.Form["mesaj"];
                ctx.Referanslar.Add(r);
                ctx.SaveChanges();
            }
        }
    }
}