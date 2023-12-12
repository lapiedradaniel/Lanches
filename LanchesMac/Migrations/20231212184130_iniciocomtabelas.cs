using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class iniciocomtabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    PedidoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Endereco1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Endereco2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PedidoTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalItensPedido = table.Column<int>(type: "int", nullable: false),
                    PedidoEnviado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PedidoEntregueEm = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.PedidoId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lanches",
                columns: table => new
                {
                    LancheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    DescricaoCurta = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescricaoDetalhada = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ImagemThumbnailUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsLanchePreferido = table.Column<bool>(type: "bit", nullable: false),
                    EmEstoque = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanches", x => x.LancheId);
                    table.ForeignKey(
                        name: "FK_Lanches_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItens",
                columns: table => new
                {
                    CarrinhoCompraItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LancheId = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CarrinhoCompraId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItens", x => x.CarrinhoCompraItemId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItens_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId");
                });

            migrationBuilder.CreateTable(
                name: "PedidosDetalhes",
                columns: table => new
                {
                    PedidoDetalheId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    LancheId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosDetalhes", x => x.PedidoDetalheId);
                    table.ForeignKey(
                        name: "FK_PedidosDetalhes_Lanches_LancheId",
                        column: x => x.LancheId,
                        principalTable: "Lanches",
                        principalColumn: "LancheId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosDetalhes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "PedidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "CategoriaNome", "Descricao" },
                values: new object[,]
                {
                    { 1, "Lanche", "Melhores Lanches" },
                    { 2, "Pizza", "Melhores Pizza" }
                });

            migrationBuilder.InsertData(
                table: "Lanches",
                columns: new[] { "LancheId", "CategoriaId", "DescricaoCurta", "DescricaoDetalhada", "EmEstoque", "ImagemThumbnailUrl", "ImagemUrl", "IsLanchePreferido", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, 1, "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", true, "Hamburger", 15.00m },
                    { 2, 1, "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", true, "Hamburger", 10.00m },
                    { 3, 1, "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", true, "Hamburger", 30.00m },
                    { 4, 1, "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", true, "Hamburger", 25.00m },
                    { 5, 1, "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty", "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png", true, "Big Tasty", 19.00m },
                    { 6, 1, "Dois hambúrgueres (100% carne bovina), mostarda, ketchup, cebola, queijo cheddar e pão com gergelim", "Dois hambúrgueres (100% carne bovina), mostarda, ketchup, cebola, queijo cheddar e pão com gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_92371_3.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_92371_3.png", true, "Duplo Quarterão", 24.00m },
                    { 7, 1, "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", "Um Hamburguer (100% carne bovina), cebola, picles, ketchup, mostarda e pão sem gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/17%20DLV.png", true, "X-burger", 12.00m },
                    { 8, 1, "Rango empanado, maionese, alface americana e pão com gergelim", "Rango empanado, maionese, alface americana e pão com gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_62_3.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_62_3.png", true, "McChicken", 20.00m },
                    { 9, 1, "Frango empanado, maionese, bacon, alface americana e pão com gergelim", "Frango empanado, maionese, bacon, alface americana e pão com gergelim", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/67477%20DLV.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/67477%20DLV.png", true, "McChicken Bacon", 23.00m },
                    { 10, 1, "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty", "Um hamburguer (100% carne bovina), queijo, tomate, alface americana, cebola e maionese Tasty", true, "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png", "https://cache-mcd-ecommerce.appmcdonalds.com/images/BR/DLV_81921_3.png", true, "Big Tasty", 19.00m },
                    { 11, 2, "Uma pizza simples, mas que conquistou uma legião de fãs em todo o mundo. Ela está presente em mais de 30% dos pedidos. Leva calabresa e cebola", "Uma pizza simples, mas que conquistou uma legião de fãs em todo o mundo. Ela está presente em mais de 30% dos pedidos. Leva calabresa e cebola", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Calabresa", 21.00m },
                    { 12, 2, "Ovos, cebola, azeitona, ervilha, queijo e presunto dão sabor à segunda pizza mais queridinha dos brasileiros", "Ovos, cebola, azeitona, ervilha, queijo e presunto dão sabor à segunda pizza mais queridinha dos brasileiros", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Portuguesa", 38.00m },
                    { 13, 2, "Sabor ícone da Itália que leva apenas molho, muçarela, tomate e manjericão. É uma ótima opção para quem não come carne", "Sabor ícone da Itália que leva apenas molho, muçarela, tomate e manjericão. É uma ótima opção para quem não come carne", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Marguerita", 36.00m },
                    { 14, 2, "A mistura de proteína e cremosidade que deu muito certo. Essa pizza recebe frango com catupiry por cima", "A mistura de proteína e cremosidade que deu muito certo. Essa pizza recebe frango com catupiry por cima", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Frango com catupiry", 27.00m },
                    { 15, 2, "Simples e perfeita como deve ser. A número 1 entre os paulistanos é tradicional na chamada pizza meio a meio", "Simples e perfeita como deve ser. A número 1 entre os paulistanos é tradicional na chamada pizza meio a meio", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Muçarela", 22.00m },
                    { 16, 2, "Um sabor genuinamente italiano que não pode faltar na sua pizzaria ou no seu pedido. Leva muçarela, azeite, molho de tomate e manjericão", "Um sabor genuinamente italiano que não pode faltar na sua pizzaria ou no seu pedido. Leva muçarela, azeite, molho de tomate e manjericão", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Napolitana", 42.00m },
                    { 17, 2, "Essa é para quem é um verdadeiro amante de queijos, pois tem quatro tipos: gorgonzola, provolone, muçarela e parmesão", "Essa é para quem é um verdadeiro amante de queijos, pois tem quatro tipos: gorgonzola, provolone, muçarela e parmesão", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Quatro queijos", 39.00m },
                    { 18, 2, "Este não é um lombo qualquer, é um do tipo canadense! Sua mistura de ingredientes contém: lombinho, cebola, bacon e champignon", "Este não é um lombo qualquer, é um do tipo canadense! Sua mistura de ingredientes contém: lombinho, cebola, bacon e champignon", true, "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", "https://img.freepik.com/fotos-gratis/feche-a-pizza-italiana-sobre-o-queijo-cole-o-foco-seletivo-generativo-ai_1258-153063.jpg", true, "Lombo canadense", 35.00m },
                    { 19, 2, "O clássico doce brasileiro que cai bem de qualquer jeito e a qualquer hora está entre as pizzas doces mais vendidas", "O clássico doce brasileiro que cai bem de qualquer jeito e a qualquer hora está entre as pizzas doces mais vendidas", true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU", true, "Brigadeiro", 29.00m },
                    { 20, 2, "A pizza de nutella é semelhante à anterior, a diferença é que ela pode ser servida sem as frutas, somente com o creme de avelã", "A pizza de nutella é semelhante à anterior, a diferença é que ela pode ser servida sem as frutas, somente com o creme de avelã", true, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSISZsaE3p0qS8tfYxybb0uOcxmJumFFgJV9Q&usqp=CAU", true, "Nutella", 39.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_LancheId",
                table: "CarrinhoCompraItens",
                column: "LancheId");

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalhes_LancheId",
                table: "PedidosDetalhes",
                column: "LancheId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosDetalhes_PedidoId",
                table: "PedidosDetalhes",
                column: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CarrinhoCompraItens");

            migrationBuilder.DropTable(
                name: "PedidosDetalhes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Lanches");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
