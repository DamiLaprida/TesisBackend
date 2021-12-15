using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIGetOut.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id_Empl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Ape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cuit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_Alta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id_Empl);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id_Prod = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lote = table.Column<long>(type: "bigint", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Pre_Uni = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id_Prod);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id_Res = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Act = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Res = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nro_Par = table.Column<int>(type: "int", nullable: false),
                    Pago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id_Res);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Emp = table.Column<int>(type: "int", nullable: false),
                    Nom_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId_Empl = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_EmpleadoId_Empl",
                        column: x => x.EmpleadoId_Empl,
                        principalTable: "Empleados",
                        principalColumn: "Id_Empl",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id_Recibo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Res = table.Column<int>(type: "int", nullable: false),
                    Id_Cli = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Fecha_Emi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservaId_Res = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id_Recibo);
                    table.ForeignKey(
                        name: "FK_Recibos_Reservas_ReservaId_Res",
                        column: x => x.ReservaId_Res,
                        principalTable: "Reservas",
                        principalColumn: "Id_Res",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservaEmpleados",
                columns: table => new
                {
                    Id_ResEmp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Res = table.Column<int>(type: "int", nullable: false),
                    Id_Emp = table.Column<int>(type: "int", nullable: false),
                    ReservaId_Res = table.Column<int>(type: "int", nullable: true),
                    EmpleadoId_Empl = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaEmpleados", x => x.Id_ResEmp);
                    table.ForeignKey(
                        name: "FK_ReservaEmpleados_Empleados_EmpleadoId_Empl",
                        column: x => x.EmpleadoId_Empl,
                        principalTable: "Empleados",
                        principalColumn: "Id_Empl",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReservaEmpleados_Reservas_ReservaId_Res",
                        column: x => x.ReservaId_Res,
                        principalTable: "Reservas",
                        principalColumn: "Id_Res",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReciboProductos",
                columns: table => new
                {
                    Id_RecProd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Recibo = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    ReciboId_Recibo = table.Column<int>(type: "int", nullable: true),
                    ProductoId_Prod = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReciboProductos", x => x.Id_RecProd);
                    table.ForeignKey(
                        name: "FK_ReciboProductos_Productos_ProductoId_Prod",
                        column: x => x.ProductoId_Prod,
                        principalTable: "Productos",
                        principalColumn: "Id_Prod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReciboProductos_Recibos_ReciboId_Recibo",
                        column: x => x.ReciboId_Recibo,
                        principalTable: "Recibos",
                        principalColumn: "Id_Recibo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReciboProductos_ProductoId_Prod",
                table: "ReciboProductos",
                column: "ProductoId_Prod");

            migrationBuilder.CreateIndex(
                name: "IX_ReciboProductos_ReciboId_Recibo",
                table: "ReciboProductos",
                column: "ReciboId_Recibo");

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_ReservaId_Res",
                table: "Recibos",
                column: "ReservaId_Res");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaEmpleados_EmpleadoId_Empl",
                table: "ReservaEmpleados",
                column: "EmpleadoId_Empl");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaEmpleados_ReservaId_Res",
                table: "ReservaEmpleados",
                column: "ReservaId_Res");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpleadoId_Empl",
                table: "Usuarios",
                column: "EmpleadoId_Empl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReciboProductos");

            migrationBuilder.DropTable(
                name: "ReservaEmpleados");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
