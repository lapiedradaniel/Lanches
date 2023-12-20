using LanchesMac.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoDetalhe> PedidosDetalhes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    CategoriaId = 1,
                    CategoriaNome = "Lanche",
                    Descricao = "Melhores Lanches"
                },
                new Categoria
                {
                    CategoriaId = 2,
                    CategoriaNome = "Pizza",
                    Descricao = "Melhores Pizza"
                },
                 new Categoria
                 {
                     CategoriaId = 3,
                     CategoriaNome = "Bebidas",
                     Descricao = "Melhores Bebidas"
                 }
            // Adicione mais categorias conforme necessário
            );

            modelBuilder.Entity<Lanche>().HasData(

                 new Lanche
                 {
                     LancheId = 1,
                     Nome = "Big Mac",
                     DescricaoCurta = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                     DescricaoDetalhada = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                     Preco = 15.00m,
                     ImagemUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kzXCTbnv/200/200/original?country=br",
                     ImagemThumbnailUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kzXCTbnv/200/200/original?country=br",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                  new Lanche
                  {
                      LancheId = 2,
                      Nome = "Quarterão com Queijo",
                      DescricaoCurta = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                      DescricaoDetalhada = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                      Preco = 10.00m,
                      ImagemUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kzXNUCF7/200/200/original?country=br",
                      ImagemThumbnailUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kzXNUCF7/200/200/original?country=br",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 1
                  },
                 new Lanche
                 {
                     LancheId = 3,
                     Nome = "Brabo Melt Crispy",
                     DescricaoCurta = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                     DescricaoDetalhada = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                     Preco = 30.00m,
                     ImagemUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kqXv9bZg/200/200/original?country=br",
                     ImagemThumbnailUrl = "https://cache-backend-mcd.mcdonaldscupones.com/media/image/product$kqXv9bZg/200/200/original?country=br",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                new Lanche
                {
                    LancheId = 4,
                    Nome = "Hamburger",
                    DescricaoCurta = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                    DescricaoDetalhada = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim",
                    Preco = 25.00m,
                    ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png",
                    ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png",
                    IsLanchePreferido = true,
                    EmEstoque = true,
                    CategoriaId = 1
                },
                new Lanche
                {
                    LancheId = 5,
                    Nome = "Big Tasty",
                    DescricaoCurta = "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty",
                    DescricaoDetalhada = "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty",
                    Preco = 19.00m,
                    ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png",
                    ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png",
                    IsLanchePreferido = true,
                    EmEstoque = true,
                    CategoriaId = 1
                },
                 new Lanche
                 {
                     LancheId = 6,
                     Nome = "Duplo Quarterão",
                     DescricaoCurta = "Dois hambúrgueres (100% carne bovina), mostarda, ketchup, cebola, queijo cheddar e pão com gergelim",
                     DescricaoDetalhada = "Dois hambúrgueres (100% carne bovina), mostarda, ketchup, cebola, queijo cheddar e pão com gergelim",
                     Preco = 24.00m,
                     ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_92371_3.png",
                     ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_92371_3.png",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                 new Lanche
                 {
                     LancheId = 7,
                     Nome = "X-burger",
                     DescricaoCurta = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão",
                     DescricaoDetalhada = "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão",
                     Preco = 12.00m,
                     ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png",
                     ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                  new Lanche
                  {
                      LancheId = 8,
                      Nome = "McChicken",
                      DescricaoCurta = "Rango empanado, maionese, alface americana e pão com gergelim",
                      DescricaoDetalhada = "Rango empanado, maionese, alface americana e pão com gergelim",
                      Preco = 20.00m,
                      ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_62_3.png",
                      ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_62_3.png",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 1
                  },
                 new Lanche
                 {
                     LancheId = 9,
                     Nome = "McChicken Bacon",
                     DescricaoCurta = "Frango empanado, maionese, bacon, alface americana e pão com gergelim",
                     DescricaoDetalhada = "Frango empanado, maionese, bacon, alface americana e pão com gergelim",
                     Preco = 23.00m,
                     ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/67477%20DLV.png",
                     ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/67477%20DLV.png",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                 new Lanche
                 {
                     LancheId = 10,
                     Nome = "Big Tasty", 
                     DescricaoCurta = "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty",
                     DescricaoDetalhada = "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty",
                     Preco = 19.00m,
                     ImagemUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png",
                     ImagemThumbnailUrl = "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 1
                 },
                 new Lanche
                 {
                     LancheId = 11,
                     Nome = "Calabresa",
                     DescricaoCurta = "Uma pizza simples, mas que conquistou uma legião de fãs em todo o mundo. Ela está presente em mais de 30% dos pedidos",
                     DescricaoDetalhada = "Uma pizza simples, mas que conquistou uma legião de fãs em todo o mundo. Ela está presente em mais de 30% dos pedidos. Leva calabresa e cebola",
                     Preco = 21.00m,
                     ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                     ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                     IsLanchePreferido = true,
                     EmEstoque = true,
                     CategoriaId = 2
                 },
                  new Lanche
                  {
                      LancheId = 12,
                      Nome = "Portuguesa",
                      DescricaoCurta = "Ovos, cebola, azeitona, ervilha, queijo e presunto dão sabor à segunda pizza mais queridinha dos brasileiros",
                      DescricaoDetalhada = "Ovos, cebola, azeitona, ervilha, queijo e presunto dão sabor à segunda pizza mais queridinha dos brasileiros",
                      Preco = 38.00m,
                      ImagemUrl = "https://maissaborgranjalisboa.onezap.link/wp-content/uploads/2022/03/Portuguesa-500x356.jpg",
                      ImagemThumbnailUrl = "https://maissaborgranjalisboa.onezap.link/wp-content/uploads/2022/03/Portuguesa-500x356.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 13,
                      Nome = "Marguerita",
                      DescricaoCurta = "Sabor ícone da Itália que leva apenas molho, muçarela, tomate e manjericão. É uma ótima opção para quem não come carne",
                      DescricaoDetalhada = "Sabor ícone da Itália que leva apenas molho, muçarela, tomate e manjericão. É uma ótima opção para quem não come carne",
                      Preco = 36.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 14,
                      Nome = "Frango com catupiry",
                      DescricaoCurta = "A mistura de proteína e cremosidade que deu muito certo. Essa pizza recebe frango com catupiry por cima",
                      DescricaoDetalhada = "A mistura de proteína e cremosidade que deu muito certo. Essa pizza recebe frango com catupiry por cima",
                      Preco = 27.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 15,
                      Nome = "Muçarela",
                      DescricaoCurta = "Simples e perfeita como deve ser. A número 1 entre os paulistanos é tradicional na chamada pizza meio a meio",
                      DescricaoDetalhada = "Simples e perfeita como deve ser. A número 1 entre os paulistanos é tradicional na chamada pizza meio a meio",
                      Preco = 22.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 16,
                      Nome = "Napolitana",
                      DescricaoCurta = "Um sabor genuinamente italiano que não pode faltar na sua pizzaria ou no seu pedido. Leva muçarela, azeite, molho de tomate",
                      DescricaoDetalhada = "Um sabor genuinamente italiano que não pode faltar na sua pizzaria ou no seu pedido. Leva muçarela, azeite, molho de tomate e manjericão",
                      Preco = 42.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 17,
                      Nome = "Quatro queijos",
                      DescricaoCurta = "Essa é para quem é um verdadeiro amante de queijos, pois tem quatro tipos: gorgonzola, provolone, muçarela e parmesão",
                      DescricaoDetalhada = "Essa é para quem é um verdadeiro amante de queijos, pois tem quatro tipos: gorgonzola, provolone, muçarela e parmesão",
                      Preco = 39.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 18,
                      Nome = "Lombo canadense",
                      DescricaoCurta = "Este não é um lombo qualquer, é um do tipo canadense! Sua mistura de ingredientes contém: lombinho, cebola e bacon",
                      DescricaoDetalhada = "Este não é um lombo qualquer, é um do tipo canadense! Sua mistura de ingredientes contém: lombinho, cebola, bacon e champignon",
                      Preco = 35.00m,
                      ImagemUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      ImagemThumbnailUrl = "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 19,
                      Nome = "Brigadeiro",
                      DescricaoCurta = "O clássico doce brasileiro que cai bem de qualquer jeito e a qualquer hora está entre as pizzas doces mais vendidas",
                      DescricaoDetalhada = "O clássico doce brasileiro que cai bem de qualquer jeito e a qualquer hora está entre as pizzas doces mais vendidas",
                      Preco = 29.00m,
                      ImagemUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU",
                      ImagemThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 20,
                      Nome = "Nutella",
                      DescricaoCurta = "A pizza de nutella é semelhante à anterior, a diferença é que ela pode ser servida sem as frutas, somente com o creme de avelã",
                      DescricaoDetalhada = "A pizza de nutella é semelhante à anterior, a diferença é que ela pode ser servida sem as frutas, somente com o creme de avelã",
                      Preco = 39.00m,
                      ImagemUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU",
                      ImagemThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 2
                  },
                  new Lanche
                  {
                      LancheId = 21,
                      Nome = "Coca-cola",
                      DescricaoCurta = "Refrigerante cola-cola",
                      DescricaoDetalhada = "Refrigerante coca-cola ",
                      Preco = 10.00m,
                      ImagemUrl = "https://i.pinimg.com/originals/52/09/77/520977593cb52286251d0de3ca50751d.png",
                      ImagemThumbnailUrl = "https://i.pinimg.com/originals/52/09/77/520977593cb52286251d0de3ca50751d.png",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 3
                  },
                  new Lanche
                  {
                      LancheId = 22,
                      Nome = "Coca-cola Lata",
                      DescricaoCurta = "Refrigerante cola-cola Lata",
                      DescricaoDetalhada = "Refrigerante coca-cola Lata",
                      Preco = 05.00m,
                      ImagemUrl = "https://cdn.awsli.com.br/800x800/446/446822/produto/231071713/162882-800-450-34cumj7dsl.jpg",
                      ImagemThumbnailUrl = "https://cdn.awsli.com.br/800x800/446/446822/produto/231071713/162882-800-450-34cumj7dsl.jpg",
                      IsLanchePreferido = true,
                      EmEstoque = true,
                      CategoriaId = 3
                  },
                   new Lanche
                   {
                       LancheId = 23,
                       Nome = "Fanta Laranja",
                       DescricaoCurta = "Refrigerante Fanta Laranja",
                       DescricaoDetalhada = "Refrigerante Fanta Laranja",
                       Preco = 10.00m,
                       ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1014792/refrigerante_fanta_laranja_retornavel_2l_24919_1_edab3291f5a10d7a3da9ca96eee01d72.png",
                       ImagemThumbnailUrl = "https://images.tcdn.com.br/img/img_prod/1014792/refrigerante_fanta_laranja_retornavel_2l_24919_1_edab3291f5a10d7a3da9ca96eee01d72.png",
                       IsLanchePreferido = true,
                       EmEstoque = true,
                       CategoriaId = 3
                   },
                   new Lanche
                   {
                       LancheId = 24,
                       Nome = "Fanta Laranja Lata",
                       DescricaoCurta = "Refrigerante Fanta Laranja Lata",
                       DescricaoDetalhada = "Refrigerante Fanta Laranja Lata",
                       Preco = 05.00m,
                       ImagemUrl = "https://cdn.awsli.com.br/2500x2500/1330/1330028/produto/51587134/5e54346f8c.jpg",
                       ImagemThumbnailUrl = "https://cdn.awsli.com.br/2500x2500/1330/1330028/produto/51587134/5e54346f8c.jpg",
                       IsLanchePreferido = true,
                       EmEstoque = true,
                       CategoriaId = 3
                   },
                   new Lanche
                   {
                       LancheId = 25,
                       Nome = "Guarana",
                       DescricaoCurta = "Refrigerante Guarana",
                       DescricaoDetalhada = "Refrigerante Guarana",
                       Preco = 10.00m,
                       ImagemUrl = "https://media.soujusto.com.br/products/5180..jpg",
                       ImagemThumbnailUrl = "https://media.soujusto.com.br/products/5180..jpg",
                       IsLanchePreferido = true,
                       EmEstoque = true,
                       CategoriaId = 3
                   },
                    new Lanche
                    {
                        LancheId = 26,
                        Nome = "Guarana Lata",
                        DescricaoCurta = "Refrigerante Guarana Lata",
                        DescricaoDetalhada = "Refrigerante Guarana Lata",
                        Preco = 05.00m,
                        ImagemUrl = "https://io.convertiez.com.br/m/drogal/shop/products/images/8290148/medium/refrigerante-guarana-antarctica-lata-350ml_16825.png",
                        ImagemThumbnailUrl = "https://io.convertiez.com.br/m/drogal/shop/products/images/8290148/medium/refrigerante-guarana-antarctica-lata-350ml_16825.png",
                        IsLanchePreferido = true,
                        EmEstoque = true,
                        CategoriaId = 3
                    },
                    new Lanche
                    {
                        LancheId = 27,
                        Nome = "Fanta Uva",
                        DescricaoCurta = "Refrigerante Fanta Uva",
                        DescricaoDetalhada = "Refrigerante Fanta Uva",
                        Preco = 10.00m,
                        ImagemUrl = "https://www.imigrantesbebidas.com.br/img/bebida/images/products/full/1897-refrigerante-fanta-uva-2l.jpg?s=a5b8770011b639aac88cda55a52db8b5",
                        ImagemThumbnailUrl = "https://www.imigrantesbebidas.com.br/img/bebida/images/products/full/1897-refrigerante-fanta-uva-2l.jpg?s=a5b8770011b639aac88cda55a52db8b5",
                        IsLanchePreferido = true,
                        EmEstoque = true,
                        CategoriaId = 3
                    },
                    new Lanche
                    {
                        LancheId = 28,
                        Nome = "Fanta Uva Lata",
                        DescricaoCurta = "Refrigerante Fanta Uva Lata",
                        DescricaoDetalhada = "Refrigerante Fanta Uva Lata",
                        Preco = 05.00m,
                        ImagemUrl = "https://media.soujusto.com.br/products/Refrigerante_Fanta_Uva_350Ml.jpg",
                        ImagemThumbnailUrl = "https://media.soujusto.com.br/products/Refrigerante_Fanta_Uva_350Ml.jpg",
                        IsLanchePreferido = true,
                        EmEstoque = true,
                        CategoriaId = 3
                    }


            // Adicione mais lanches conforme necessário
            );

            // Outras configurações do modelo...
        }

    }

}
