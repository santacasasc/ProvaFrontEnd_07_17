using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ProvaFrontEnd_07_17.Models.Noticias
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public int NoticiaId { get; set; }

        public int LayoutId { get; set; }

        public string URL { get; set; }

        public string Texto { get; set; }

        [ScriptIgnore]
        public virtual Noticia Noticia { get; set; }

        [ScriptIgnore]
        public virtual Layout Layout { get; set; }

    }
}