using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class Referanssil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Referanssil.aspx?ID=2
            int gelenid = Convert.ToInt32(Request.QueryString["ID"]);

            KurumsalContext ctx = new KurumsalContext();
            Referans r = ctx.Referanslar.Find(gelenid);
            ctx.Referanslar.Remove(r);
            ctx.SaveChanges();

            Response.Redirect("/Referanslar.aspx");

        }
    }
}