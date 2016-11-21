using Kurumsal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurumsal
{
    public partial class Ayar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //eğer form harekete geçmişse, butona tıklanmışsa
            if (IsPostBack) { 
                //kullanıcı verilerini GET ile ilettiyse
                //NOT: tırnak içerisinde yazdığımız isimler (email, copyright) inputların name i ile eşleşir.
                string emailget = Request.QueryString["email"];
                string copyrightget = Request.QueryString["copyright"];

                //post ile ilettiyse
                string emailpost = Request.Form["email"];
                string copyrightpost = Request.Form["copyright"];

                //Veritabanıyla haberleşmek için ctx nesnemiz
                KurumsalContext ctx = new KurumsalContext();
                //veritabanında daha önce kaydedilmiş bir ayar satırı varmı
                Models.Ayar a = ctx.Ayarlar.FirstOrDefault();
                //eğer yoksa
                if (a == null) {
                    //yeni bir ayar satırı oluşturduk
                    Models.Ayar yeniayar = new Models.Ayar();
                    //modeller klasöründeki Ayar.cs dosyasında satırın detayları tanımlı
                    yeniayar.Copyright = copyrightpost;
                    yeniayar.MailAdres = emailpost;
                    //veritabanıda ayarlar tablosuna ekle
                    ctx.Ayarlar.Add(yeniayar);
                    //veritabanına kaydet
                    ctx.SaveChanges();
                }
            }
        }
    }
}