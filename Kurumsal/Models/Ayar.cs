using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kurumsal.Models
{
    [Table("tblAyar")]
    public class Ayar
    {
        [Key]
        public int AyarID { get; set; }
        public string Logo { get; set; }
        public string Copyright { get; set; }
        public string MailAdres { get; set; }
    }
}