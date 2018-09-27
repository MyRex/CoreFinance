using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZFine.Web.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sys_Area",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_SimpleSpelling = table.Column<string>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Area", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_DbBackup",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_Type = table.Column<bool>(nullable: true),
                    F_StartIP = table.Column<string>(nullable: true),
                    F_EndIP = table.Column<string>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_DbBackup", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_FilterIP",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_BackupType = table.Column<string>(nullable: true),
                    F_DbName = table.Column<string>(nullable: true),
                    F_FileName = table.Column<string>(nullable: true),
                    F_FileSize = table.Column<string>(nullable: true),
                    F_FilePath = table.Column<string>(nullable: true),
                    F_BackupTime = table.Column<DateTime>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_FilterIP", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Items",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_IsTree = table.Column<bool>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Items", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ItemsDetail",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ItemId = table.Column<string>(nullable: true),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_ItemCode = table.Column<string>(nullable: true),
                    F_ItemName = table.Column<string>(nullable: true),
                    F_SimpleSpelling = table.Column<string>(nullable: true),
                    F_IsDefault = table.Column<bool>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ItemsDetail", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Log",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_Date = table.Column<DateTime>(nullable: true),
                    F_Account = table.Column<string>(nullable: true),
                    F_NickName = table.Column<string>(nullable: true),
                    F_Type = table.Column<string>(nullable: true),
                    F_IPAddress = table.Column<string>(nullable: true),
                    F_IPAddressName = table.Column<string>(nullable: true),
                    F_ModuleId = table.Column<string>(nullable: true),
                    F_ModuleName = table.Column<string>(nullable: true),
                    F_Result = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Log", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Module",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_Icon = table.Column<string>(nullable: true),
                    F_UrlAddress = table.Column<string>(nullable: true),
                    F_Target = table.Column<string>(nullable: true),
                    F_IsMenu = table.Column<bool>(nullable: true),
                    F_IsExpand = table.Column<bool>(nullable: true),
                    F_IsPublic = table.Column<bool>(nullable: true),
                    F_AllowEdit = table.Column<bool>(nullable: true),
                    F_AllowDelete = table.Column<bool>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Module", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_ModuleButton",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ModuleId = table.Column<string>(nullable: true),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_Icon = table.Column<string>(nullable: true),
                    F_Location = table.Column<int>(nullable: true),
                    F_JsEvent = table.Column<string>(nullable: true),
                    F_UrlAddress = table.Column<string>(nullable: true),
                    F_Split = table.Column<bool>(nullable: true),
                    F_IsPublic = table.Column<bool>(nullable: true),
                    F_AllowEdit = table.Column<bool>(nullable: true),
                    F_AllowDelete = table.Column<bool>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_ModuleButton", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Organize",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ParentId = table.Column<string>(nullable: true),
                    F_Layers = table.Column<int>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_ShortName = table.Column<string>(nullable: true),
                    F_CategoryId = table.Column<string>(nullable: true),
                    F_ManagerId = table.Column<string>(nullable: true),
                    F_TelePhone = table.Column<string>(nullable: true),
                    F_MobilePhone = table.Column<string>(nullable: true),
                    F_WeChat = table.Column<string>(nullable: true),
                    F_Fax = table.Column<string>(nullable: true),
                    F_Email = table.Column<string>(nullable: true),
                    F_AreaId = table.Column<string>(nullable: true),
                    F_Address = table.Column<string>(nullable: true),
                    F_AllowEdit = table.Column<bool>(nullable: true),
                    F_AllowDelete = table.Column<bool>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Organize", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_Role",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_OrganizeId = table.Column<string>(nullable: true),
                    F_Category = table.Column<int>(nullable: true),
                    F_EnCode = table.Column<string>(nullable: true),
                    F_FullName = table.Column<string>(nullable: true),
                    F_Type = table.Column<string>(nullable: true),
                    F_AllowEdit = table.Column<bool>(nullable: true),
                    F_AllowDelete = table.Column<bool>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_Role", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_RoleAuthorize",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_ItemType = table.Column<int>(nullable: true),
                    F_ItemId = table.Column<string>(nullable: true),
                    F_ObjectType = table.Column<int>(nullable: true),
                    F_ObjectId = table.Column<string>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_RoleAuthorize", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_User",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_Account = table.Column<string>(nullable: true),
                    F_RealName = table.Column<string>(nullable: true),
                    F_NickName = table.Column<string>(nullable: true),
                    F_HeadIcon = table.Column<string>(nullable: true),
                    F_Gender = table.Column<bool>(nullable: true),
                    F_Birthday = table.Column<DateTime>(nullable: true),
                    F_MobilePhone = table.Column<string>(nullable: true),
                    F_Email = table.Column<string>(nullable: true),
                    F_WeChat = table.Column<string>(nullable: true),
                    F_ManagerId = table.Column<string>(nullable: true),
                    F_SecurityLevel = table.Column<int>(nullable: true),
                    F_Signature = table.Column<string>(nullable: true),
                    F_OrganizeId = table.Column<string>(nullable: true),
                    F_DepartmentId = table.Column<string>(nullable: true),
                    F_RoleId = table.Column<string>(nullable: true),
                    F_DutyId = table.Column<string>(nullable: true),
                    F_IsAdministrator = table.Column<bool>(nullable: true),
                    F_SortCode = table.Column<int>(nullable: true),
                    F_DeleteMark = table.Column<bool>(nullable: true),
                    F_EnabledMark = table.Column<bool>(nullable: true),
                    F_Description = table.Column<string>(nullable: true),
                    F_CreatorTime = table.Column<DateTime>(nullable: true),
                    F_CreatorUserId = table.Column<string>(nullable: true),
                    F_LastModifyTime = table.Column<DateTime>(nullable: true),
                    F_LastModifyUserId = table.Column<string>(nullable: true),
                    F_DeleteTime = table.Column<DateTime>(nullable: true),
                    F_DeleteUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_User", x => x.F_Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys_UserLogOn",
                columns: table => new
                {
                    F_Id = table.Column<string>(nullable: false),
                    F_UserId = table.Column<string>(nullable: true),
                    F_UserPassword = table.Column<string>(nullable: true),
                    F_UserSecretkey = table.Column<string>(nullable: true),
                    F_AllowStartTime = table.Column<DateTime>(nullable: true),
                    F_AllowEndTime = table.Column<DateTime>(nullable: true),
                    F_LockStartDate = table.Column<DateTime>(nullable: true),
                    F_LockEndDate = table.Column<DateTime>(nullable: true),
                    F_FirstVisitTime = table.Column<DateTime>(nullable: true),
                    F_PreviousVisitTime = table.Column<DateTime>(nullable: true),
                    F_LastVisitTime = table.Column<DateTime>(nullable: true),
                    F_ChangePasswordDate = table.Column<DateTime>(nullable: true),
                    F_MultiUserLogin = table.Column<bool>(nullable: true),
                    F_LogOnCount = table.Column<int>(nullable: true),
                    F_UserOnLine = table.Column<bool>(nullable: true),
                    F_Question = table.Column<string>(nullable: true),
                    F_AnswerQuestion = table.Column<string>(nullable: true),
                    F_CheckIPAddress = table.Column<bool>(nullable: true),
                    F_Language = table.Column<string>(nullable: true),
                    F_Theme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys_UserLogOn", x => x.F_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sys_Area");

            migrationBuilder.DropTable(
                name: "Sys_DbBackup");

            migrationBuilder.DropTable(
                name: "Sys_FilterIP");

            migrationBuilder.DropTable(
                name: "Sys_Items");

            migrationBuilder.DropTable(
                name: "Sys_ItemsDetail");

            migrationBuilder.DropTable(
                name: "Sys_Log");

            migrationBuilder.DropTable(
                name: "Sys_Module");

            migrationBuilder.DropTable(
                name: "Sys_ModuleButton");

            migrationBuilder.DropTable(
                name: "Sys_Organize");

            migrationBuilder.DropTable(
                name: "Sys_Role");

            migrationBuilder.DropTable(
                name: "Sys_RoleAuthorize");

            migrationBuilder.DropTable(
                name: "Sys_User");

            migrationBuilder.DropTable(
                name: "Sys_UserLogOn");
        }
    }
}
