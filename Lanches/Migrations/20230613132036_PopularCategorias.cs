using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(categoriaNome, Descricao)"+ "VALUES('Sandwiches', 'Lanche feito com ingredientes comuns')");

            migrationBuilder.Sql("INSERT INTO Categorias(categoriaNome, Descricao)" + "VALUES('Natural', 'Lanche feito com ingredientes  integrais e naturais')");

            migrationBuilder.Sql("INSERT INTO Categorias(categoriaNome, Descricao)" + "VALUES('Hamburgues', 'Hamburguers deliciosos')");

            migrationBuilder.Sql("INSERT INTO Categorias(categoriaNome, Descricao)" + "VALUES('Bebidas', 'Refrigerantes e sucos Naturais.')");

            migrationBuilder.Sql("INSERT INTO Categorias(categoriaNome, Descricao)" + "VALUES('Combos', 'Sanwiches ou hamburgues acompoanhados com batata e refrigerante')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
