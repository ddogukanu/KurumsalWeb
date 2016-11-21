﻿using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class Icerikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KurumsalContext ctx = new KurumsalContext();
            Repeater1.DataSource = ctx.Icerikler.ToList();
            Repeater1.DataBind(); //veriyi aktarmaya başla
        }
    }
}