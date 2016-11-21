using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class IcerikEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                KurumsalContext ctx = new KurumsalContext();
                Icerik r = new Icerik();
                r.Baslik = Request.Form["baslik"]; //name i adsoyad olan inputa yazılan buraya gelir.
                r.Makale = Request.Form["makale"];
                ctx.Icerikler.Add(r);
                ctx.SaveChanges();
            }
        }
    }
}