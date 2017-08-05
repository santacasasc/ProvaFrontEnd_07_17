using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Script.Serialization;

namespace ProvaFrontEnd_07_17.Models.Noticias
{
    public class Layout
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        [ScriptIgnore]
        public IList<Item> Itens { get; set; }

    }
}