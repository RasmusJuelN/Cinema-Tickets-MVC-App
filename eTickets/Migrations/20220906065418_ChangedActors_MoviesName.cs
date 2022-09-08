using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTickets.Migrations
{
    public partial class ChangedActors_MoviesName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_Movies",
                newName: "Actors_And_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_And_Movies",
                newName: "IX_Actors_And_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_And_Movies",
                table: "Actors_And_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_And_Movies_Actors_ActorId",
                table: "Actors_And_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_And_Movies_Movies_MovieId",
                table: "Actors_And_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_And_Movies_Actors_ActorId",
                table: "Actors_And_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_And_Movies_Movies_MovieId",
                table: "Actors_And_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors_And_Movies",
                table: "Actors_And_Movies");

            migrationBuilder.RenameTable(
                name: "Actors_And_Movies",
                newName: "Actors_Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_And_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors_Movies",
                table: "Actors_Movies",
                columns: new[] { "ActorId", "MovieId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Actors_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
