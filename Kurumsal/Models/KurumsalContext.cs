using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kurumsal.Models
{
    public class KurumsalContext : DbContext
    {
        public virtual DbSet<Ayar> Ayarlar { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<Referans> Referanslar { get; set; }
        public virtual DbSet<Icerik> Icerikler { get; set; }
    }
}

/*
 <connectionStrings>
    <add name="KurumsalContext" providerName="System.Data.SqlClient" 
 connectionString="Server=WISSEN164; User ID=student; Integrated Security=true; Database=KurumDB;"/>
 </connectionStrings>
  
 <system.web>
 */

/*
 Tools -> Nuget Package Manager -> Console
 * 
 enable-migrations -enableAutomaticMigrations
 
 hata verirse: update-package "EntityFramework" -reinstall
 * 
 update-database : sqlde veritabanının oluşmasını sağlar
 */