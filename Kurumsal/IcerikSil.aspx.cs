using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class IcerikSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IcerikSil.aspx?ID=1
            string gelenid = Request.QueryString["ID"]; //1

            //veritabanından sil
            KurumsalContext ctx = new KurumsalContext();
            //id si belli olan Icerik nesnesini bul
            Icerik i = ctx.Icerikler.Find(Convert.ToInt32(gelenid));
            //veritabanındaki içeriklerden bulduğumuzu sil
            ctx.Icerikler.Remove(i);
            ctx.SaveChanges();

            //icerik sayfasına yönlendir
            Response.Redirect("/Icerikler.aspx");
        }
    }
}