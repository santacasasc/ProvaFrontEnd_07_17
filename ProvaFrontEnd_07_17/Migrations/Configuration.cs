namespace ProvaFrontEnd_07_17.Migrations
{
    using ProvaFrontEnd_07_17.Models.Noticias;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProvaFrontEnd_07_17.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProvaFrontEnd_07_17.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Categoria CatGeral = new Categoria { Nome = "Geral" };
            Categoria CatInovacao = new Categoria { Nome = "Inovação" };
            Categoria CatAtualidades = new Categoria { Nome = "Atualidades" };

            IList<Categoria> Categorias = new List<Categoria> { CatGeral,
                CatInovacao,
                CatAtualidades };

            Layout LayoutTexto = new Layout { Descricao = "Somente Texto", Nome = "Texto" };
            Layout LayoutBannerImagem = new Layout { Descricao = "Somente uma imagem de banner ", Nome = "Banner" };
            Layout LayoutTextoImagemDireita = new Layout { Descricao = "Texto com uma imagem a direita", Nome = "Imagem Direita" };
            Layout LayoutTextoImagemEsquerda = new Layout { Descricao = "Texto com uma imagem a esquerda", Nome = "Imagem Esquerda" };

            IList<Layout> Layouts = new List<Layout> { LayoutTexto,
                LayoutBannerImagem,
                LayoutTextoImagemDireita,
                LayoutTextoImagemEsquerda };

            Noticia Noticia1 = new Noticia { Titulo = "Notícia 1", URL = "noticia_1", Categoria = CatGeral, Imagem="noticia1.jpg", ImagemFacebook= "noticia1face.jpg" };
            Item Item1 = new Item { Noticia = Noticia1, Layout = LayoutBannerImagem, URL="banner1.jpg" };
            Item Item2 = new Item { Noticia = Noticia1, Layout = LayoutTexto, Texto = @"Spicy jalapeno bacon ipsum dolor amet pork belly eu ham magna dolore. Enim jowl duis, dolore quis sirloin t-bone sausage swine biltong adipisicing porchetta id. Laborum ribeye eiusmod dolore pork belly pancetta frankfurter andouille hamburger. Swine occaecat officia sirloin boudin. Chicken tri-tip spare ribs, voluptate sausage bacon nostrud laboris laborum ground round dolor nulla ball tip pork belly filet mignon. In pork belly pastrami fatback quis sausage salami ad lorem burgdoggen mollit doner laborum adipisicing andouille. Eu id dolor exercitation.
                Do spare ribs adipisicing jowl pig boudin. Pork loin bresaola turkey adipisicing. Quis brisket adipisicing duis in swine filet mignon anim shank dolore non laborum voluptate ipsum lorem. Ad ham hock beef jerky. Do t-bone chicken, tri-tip incididunt officia et ball tip drumstick pastrami sint. Ham hock short loin tail turkey esse pariatur chicken sed t-bone culpa excepteur eu cillum pork belly rump. Brisket shankle occaecat tongue, est in boudin porchetta exercitation consequat salami ea consectetur shank." };


            Noticia Noticia2 = new Noticia { Titulo = "Notícia 2", URL = "noticia_2", Categoria = CatInovacao, Imagem = "noticia2.jpg", ImagemFacebook = "noticia2face.jpg" };
            Item Item3 = new Item { Noticia = Noticia2, Layout = LayoutTextoImagemDireita, URL="img1.jpg", Texto = @"Id consectetur aliquip ut bacon. Est duis magna culpa capicola porchetta t-bone occaecat picanha prosciutto. Strip steak excepteur spare ribs shoulder ad aute ea pork belly salami nostrud minim sirloin culpa ham hock. Drumstick pancetta reprehenderit, meatball velit laborum pork belly short ribs ham. Adipisicing aliqua shankle, pork belly bresaola cupidatat drumstick porchetta voluptate fatback duis ex. Minim consectetur lorem, short loin ball tip dolore venison.
                Magna corned beef deserunt exercitation filet mignon, excepteur dolor beef ribs tenderloin short ribs mollit burgdoggen lorem ut. Sirloin mollit magna elit biltong dolore rump, cupidatat cow fatback tempor filet mignon meatloaf. Esse flank do consectetur. Cow andouille ball tip, turkey elit short ribs exercitation reprehenderit deserunt salami quis commodo porchetta.
                Cillum proident laborum, t-bone tenderloin sirloin consequat sausage pork non duis pork belly elit flank pastrami. Reprehenderit burgdoggen nulla officia non turkey. Ea pig picanha tongue chuck labore filet mignon qui eu swine spare ribs excepteur sint fugiat brisket. Aute tempor aliquip exercitation short loin in jerky t-bone boudin doner pork landjaeger sausage. Lorem consectetur in, short ribs adipisicing laborum drumstick turkey. Velit turkey aute ribeye chicken ham labore meatball. Meatball aliquip non cupidatat meatloaf andouille do ut et picanha." };
            Item Item4 = new Item { Noticia = Noticia2, Layout = LayoutTextoImagemEsquerda,URL = "img2.jpg", Texto = @"Id consectetur aliquip ut bacon. Est duis magna culpa capicola porchetta t-bone occaecat picanha prosciutto. Strip steak excepteur spare ribs shoulder ad aute ea pork belly salami nostrud minim sirloin culpa ham hock. Drumstick pancetta reprehenderit, meatball velit laborum pork belly short ribs ham. Adipisicing aliqua shankle, pork belly bresaola cupidatat drumstick porchetta voluptate fatback duis ex. Minim consectetur lorem, short loin ball tip dolore venison.
                Magna corned beef deserunt exercitation filet mignon, excepteur dolor beef ribs tenderloin short ribs mollit burgdoggen lorem ut. Sirloin mollit magna elit biltong dolore rump, cupidatat cow fatback tempor filet mignon meatloaf. Esse flank do consectetur. Cow andouille ball tip, turkey elit short ribs exercitation reprehenderit deserunt salami quis commodo porchetta.
                Cillum proident laborum, t-bone tenderloin sirloin consequat sausage pork non duis pork belly elit flank pastrami. Reprehenderit burgdoggen nulla officia non turkey. Ea pig picanha tongue chuck labore filet mignon qui eu swine spare ribs excepteur sint fugiat brisket. Aute tempor aliquip exercitation short loin in jerky t-bone boudin doner pork landjaeger sausage. Lorem consectetur in, short ribs adipisicing laborum drumstick turkey. Velit turkey aute ribeye chicken ham labore meatball. Meatball aliquip non cupidatat meatloaf andouille do ut et picanha." };

            Noticia Noticia3 = new Noticia { Titulo = "Notícia 3", URL = "noticia_3", Categoria = CatAtualidades, Imagem = "noticia3.jpg", ImagemFacebook = "noticia3face.jpg" };
            Item Item5 = new Item { Noticia = Noticia3, Layout = LayoutTextoImagemDireita, URL= "img3.jpg", Texto = @"Id consectetur aliquip ut bacon. Est duis magna culpa capicola porchetta t-bone occaecat picanha prosciutto. Strip steak excepteur spare ribs shoulder ad aute ea pork belly salami nostrud minim sirloin culpa ham hock. Drumstick pancetta reprehenderit, meatball velit laborum pork belly short ribs ham. Adipisicing aliqua shankle, pork belly bresaola cupidatat drumstick porchetta voluptate fatback duis ex. Minim consectetur lorem, short loin ball tip dolore venison.
                Magna corned beef deserunt exercitation filet mignon, excepteur dolor beef ribs tenderloin short ribs mollit burgdoggen lorem ut. Sirloin mollit magna elit biltong dolore rump, cupidatat cow fatback tempor filet mignon meatloaf. Esse flank do consectetur. Cow andouille ball tip, turkey elit short ribs exercitation reprehenderit deserunt salami quis commodo porchetta.
                Cillum proident laborum, t-bone tenderloin sirloin consequat sausage pork non duis pork belly elit flank pastrami. Reprehenderit burgdoggen nulla officia non turkey. Ea pig picanha tongue chuck labore filet mignon qui eu swine spare ribs excepteur sint fugiat brisket. Aute tempor aliquip exercitation short loin in jerky t-bone boudin doner pork landjaeger sausage. Lorem consectetur in, short ribs adipisicing laborum drumstick turkey. Velit turkey aute ribeye chicken ham labore meatball. Meatball aliquip non cupidatat meatloaf andouille do ut et picanha." };
            Item Item6 = new Item { Noticia = Noticia3, Layout = LayoutTexto, Texto = @"Id consectetur aliquip ut bacon. Est duis magna culpa capicola porchetta t-bone occaecat picanha prosciutto. Strip steak excepteur spare ribs shoulder ad aute ea pork belly salami nostrud minim sirloin culpa ham hock. Drumstick pancetta reprehenderit, meatball velit laborum pork belly short ribs ham. Adipisicing aliqua shankle, pork belly bresaola cupidatat drumstick porchetta voluptate fatback duis ex. Minim consectetur lorem, short loin ball tip dolore venison.
                Magna corned beef deserunt exercitation filet mignon, excepteur dolor beef ribs tenderloin short ribs mollit burgdoggen lorem ut. Sirloin mollit magna elit biltong dolore rump, cupidatat cow fatback tempor filet mignon meatloaf. Esse flank do consectetur. Cow andouille ball tip, turkey elit short ribs exercitation reprehenderit deserunt salami quis commodo porchetta.
                Cillum proident laborum, t-bone tenderloin sirloin consequat sausage pork non duis pork belly elit flank pastrami. Reprehenderit burgdoggen nulla officia non turkey. Ea pig picanha tongue chuck labore filet mignon qui eu swine spare ribs excepteur sint fugiat brisket. Aute tempor aliquip exercitation short loin in jerky t-bone boudin doner pork landjaeger sausage. Lorem consectetur in, short ribs adipisicing laborum drumstick turkey. Velit turkey aute ribeye chicken ham labore meatball. Meatball aliquip non cupidatat meatloaf andouille do ut et picanha." };

            IList<Noticia> Noticas = new List<Noticia> { Noticia1,
                Noticia2,
                Noticia3 };

            IList<Item> Itens = new List<Item> {
                Item1,
                Item2,
                Item3,
                Item4,
                Item5,
                Item6};


            foreach (var c in Categorias)
            {
                if (context.Categorias.Where(m => m.Nome == c.Nome).FirstOrDefault() == null)
                {
                    context.Categorias.Add(c);
                }
            }

            foreach (var l in Layouts)
            {
                if (context.Layouts.Where(m => m.Nome == l.Nome).FirstOrDefault() == null)
                {
                    context.Layouts.Add(l);
                }
            }

            foreach (var i in Itens)
            {
                if (context.Items.Where(m => m.Texto == i.Texto && m.URL == i.URL).FirstOrDefault() == null)
                {
                    context.Items.Add(i);
                }
            }

            foreach (var n in Noticas)
            {
                if (context.Noticias.Where(m => m.Titulo == n.Titulo).FirstOrDefault() == null)
                {
                    context.Noticias.Add(n);
                }
            }

        }
    }
}
