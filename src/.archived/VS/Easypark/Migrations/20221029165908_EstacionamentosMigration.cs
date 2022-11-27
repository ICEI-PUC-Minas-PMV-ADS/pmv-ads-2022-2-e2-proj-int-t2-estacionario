using Microsoft.EntityFrameworkCore.Migrations;

namespace Easypark.Migrations
{
    public partial class EstacionamentosMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaCarroEletricocodigoEstacionamento",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagacodigoEstacionamento",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaDeficientecodigoEstacionamento",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaIdosocodigoEstacionamento",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaRegularcodigoEstacionamento",
                table: "Estacionamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VagaModel",
                table: "VagaModel");

            migrationBuilder.RenameColumn(
                name: "vagacodigoEstacionamento",
                table: "Estacionamentos",
                newName: "vagacodigoVagasDisponiveis");

            migrationBuilder.RenameColumn(
                name: "vagaRegularcodigoEstacionamento",
                table: "Estacionamentos",
                newName: "vagaRegularcodigoVagasDisponiveis");

            migrationBuilder.RenameColumn(
                name: "vagaIdosocodigoEstacionamento",
                table: "Estacionamentos",
                newName: "vagaIdosocodigoVagasDisponiveis");

            migrationBuilder.RenameColumn(
                name: "vagaDeficientecodigoEstacionamento",
                table: "Estacionamentos",
                newName: "vagaDeficientecodigoVagasDisponiveis");

            migrationBuilder.RenameColumn(
                name: "vagaCarroEletricocodigoEstacionamento",
                table: "Estacionamentos",
                newName: "vagaCarroEletricocodigoVagasDisponiveis");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaRegularcodigoEstacionamento",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaRegularcodigoVagasDisponiveis");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaIdosocodigoEstacionamento",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaIdosocodigoVagasDisponiveis");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaDeficientecodigoEstacionamento",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaDeficientecodigoVagasDisponiveis");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagacodigoEstacionamento",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagacodigoVagasDisponiveis");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaCarroEletricocodigoEstacionamento",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaCarroEletricocodigoVagasDisponiveis");

            migrationBuilder.AlterColumn<int>(
                name: "codigoEstacionamento",
                table: "VagaModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "codigoVagasDisponiveis",
                table: "VagaModel",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VagaModel",
                table: "VagaModel",
                column: "codigoVagasDisponiveis");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaCarroEletricocodigoVagasDisponiveis",
                table: "Estacionamentos",
                column: "vagaCarroEletricocodigoVagasDisponiveis",
                principalTable: "VagaModel",
                principalColumn: "codigoVagasDisponiveis",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagacodigoVagasDisponiveis",
                table: "Estacionamentos",
                column: "vagacodigoVagasDisponiveis",
                principalTable: "VagaModel",
                principalColumn: "codigoVagasDisponiveis",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaDeficientecodigoVagasDisponiveis",
                table: "Estacionamentos",
                column: "vagaDeficientecodigoVagasDisponiveis",
                principalTable: "VagaModel",
                principalColumn: "codigoVagasDisponiveis",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaIdosocodigoVagasDisponiveis",
                table: "Estacionamentos",
                column: "vagaIdosocodigoVagasDisponiveis",
                principalTable: "VagaModel",
                principalColumn: "codigoVagasDisponiveis",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaRegularcodigoVagasDisponiveis",
                table: "Estacionamentos",
                column: "vagaRegularcodigoVagasDisponiveis",
                principalTable: "VagaModel",
                principalColumn: "codigoVagasDisponiveis",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaCarroEletricocodigoVagasDisponiveis",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagacodigoVagasDisponiveis",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaDeficientecodigoVagasDisponiveis",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaIdosocodigoVagasDisponiveis",
                table: "Estacionamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaRegularcodigoVagasDisponiveis",
                table: "Estacionamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VagaModel",
                table: "VagaModel");

            migrationBuilder.DropColumn(
                name: "codigoVagasDisponiveis",
                table: "VagaModel");

            migrationBuilder.RenameColumn(
                name: "vagacodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "vagacodigoEstacionamento");

            migrationBuilder.RenameColumn(
                name: "vagaRegularcodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "vagaRegularcodigoEstacionamento");

            migrationBuilder.RenameColumn(
                name: "vagaIdosocodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "vagaIdosocodigoEstacionamento");

            migrationBuilder.RenameColumn(
                name: "vagaDeficientecodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "vagaDeficientecodigoEstacionamento");

            migrationBuilder.RenameColumn(
                name: "vagaCarroEletricocodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "vagaCarroEletricocodigoEstacionamento");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaRegularcodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaRegularcodigoEstacionamento");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaIdosocodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaIdosocodigoEstacionamento");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaDeficientecodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaDeficientecodigoEstacionamento");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagacodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagacodigoEstacionamento");

            migrationBuilder.RenameIndex(
                name: "IX_Estacionamentos_vagaCarroEletricocodigoVagasDisponiveis",
                table: "Estacionamentos",
                newName: "IX_Estacionamentos_vagaCarroEletricocodigoEstacionamento");

            migrationBuilder.AlterColumn<int>(
                name: "codigoEstacionamento",
                table: "VagaModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VagaModel",
                table: "VagaModel",
                column: "codigoEstacionamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaCarroEletricocodigoEstacionamento",
                table: "Estacionamentos",
                column: "vagaCarroEletricocodigoEstacionamento",
                principalTable: "VagaModel",
                principalColumn: "codigoEstacionamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagacodigoEstacionamento",
                table: "Estacionamentos",
                column: "vagacodigoEstacionamento",
                principalTable: "VagaModel",
                principalColumn: "codigoEstacionamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaDeficientecodigoEstacionamento",
                table: "Estacionamentos",
                column: "vagaDeficientecodigoEstacionamento",
                principalTable: "VagaModel",
                principalColumn: "codigoEstacionamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaIdosocodigoEstacionamento",
                table: "Estacionamentos",
                column: "vagaIdosocodigoEstacionamento",
                principalTable: "VagaModel",
                principalColumn: "codigoEstacionamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Estacionamentos_VagaModel_vagaRegularcodigoEstacionamento",
                table: "Estacionamentos",
                column: "vagaRegularcodigoEstacionamento",
                principalTable: "VagaModel",
                principalColumn: "codigoEstacionamento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
