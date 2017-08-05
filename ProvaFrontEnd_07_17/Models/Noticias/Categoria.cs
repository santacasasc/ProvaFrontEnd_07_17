using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;

namespace ProvaFrontEnd_07_17.Models.Noticias
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [ScriptIgnore]
        public virtual IList<Noticia> Noticias { get; set; }

    }
}