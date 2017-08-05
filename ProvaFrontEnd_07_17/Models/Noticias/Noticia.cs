using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaFrontEnd_07_17.Models.Noticias
{
    public class Noticia
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string URL { get; set; }

        public string Imagem { get; set; }

        public string ImagemFacebook { get; set; }

        public int CategoriaId { get; set; }

        public virtual IList<Item> Itens { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}