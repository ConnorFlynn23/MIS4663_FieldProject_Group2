using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS4663_FieldProject_Group2.Migrations
{
    /// <inheritdoc />
    public partial class DbCon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TCompanyDescription",
                columns: table => new
                {
                    CompanyDescID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Background = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Mission = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Structure = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Product = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Goals = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TCompany__C61893BFE4461C62", x => x.CompanyDescID);
                });

            migrationBuilder.CreateTable(
                name: "TContact",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    LName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContactEmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TContact__5C6625BBDEDF9F99", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "TRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleDesc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TRoles__8AFACE3A766E3B2B", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "TUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TUsers__1788CCAC4BC17F54", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__TUsers__ContactI__49C3F6B7",
                        column: x => x.ContactID,
                        principalTable: "TContact",
                        principalColumn: "ContactID");
                });

            migrationBuilder.CreateTable(
                name: "TPermissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TPermiss__EFA6FB0FFF1B7BD4", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK__TPermissi__RoleI__5070F446",
                        column: x => x.RoleID,
                        principalTable: "TRoles",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "TProject",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CompanyDescID = table.Column<int>(type: "int", nullable: false),
                    ProjectDesc = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ProjectExp = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ProjectConst = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProjectStatus = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TProject__761ABED0B4913DA5", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK__TProject__Compan__4D94879B",
                        column: x => x.CompanyDescID,
                        principalTable: "TCompanyDescription",
                        principalColumn: "CompanyDescID");
                    table.ForeignKey(
                        name: "FK__TProject__UserID__4CA06362",
                        column: x => x.UserID,
                        principalTable: "TUsers",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "TUserRole",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TUserRol__3D978A5523FC7CCB", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK__TUserRole__RoleI__5441852A",
                        column: x => x.RoleID,
                        principalTable: "TRoles",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK__TUserRole__UserI__534D60F1",
                        column: x => x.UserID,
                        principalTable: "TUsers",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TPermissions_RoleID",
                table: "TPermissions",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_TProject_CompanyDescID",
                table: "TProject",
                column: "CompanyDescID");

            migrationBuilder.CreateIndex(
                name: "IX_TProject_UserID",
                table: "TProject",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TUserRole_RoleID",
                table: "TUserRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_TUserRole_UserID",
                table: "TUserRole",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TUsers_ContactID",
                table: "TUsers",
                column: "ContactID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TPermissions");

            migrationBuilder.DropTable(
                name: "TProject");

            migrationBuilder.DropTable(
                name: "TUserRole");

            migrationBuilder.DropTable(
                name: "TCompanyDescription");

            migrationBuilder.DropTable(
                name: "TRoles");

            migrationBuilder.DropTable(
                name: "TUsers");

            migrationBuilder.DropTable(
                name: "TContact");
        }
    }
}
