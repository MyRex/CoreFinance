﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZFine.Domain.Entity;

namespace ZFine.Web.Migrations
{
    [DbContext(typeof(ZFineDbContext))]
    partial class ZFineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.AreaEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FullName");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<string>("F_ParentId");

                    b.Property<string>("F_SimpleSpelling");

                    b.Property<int?>("F_SortCode");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Area");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.ItemsDetailEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<bool?>("F_IsDefault");

                    b.Property<string>("F_ItemCode");

                    b.Property<string>("F_ItemId");

                    b.Property<string>("F_ItemName");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<string>("F_ParentId");

                    b.Property<string>("F_SimpleSpelling");

                    b.Property<int?>("F_SortCode");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_ItemsDetail");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.ItemsEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FullName");

                    b.Property<bool?>("F_IsTree");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<string>("F_ParentId");

                    b.Property<int?>("F_SortCode");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Items");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.ModuleButtonEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("F_AllowDelete");

                    b.Property<bool?>("F_AllowEdit");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FullName");

                    b.Property<string>("F_Icon");

                    b.Property<bool?>("F_IsPublic");

                    b.Property<string>("F_JsEvent");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<int?>("F_Location");

                    b.Property<string>("F_ModuleId");

                    b.Property<string>("F_ParentId");

                    b.Property<int?>("F_SortCode");

                    b.Property<bool?>("F_Split");

                    b.Property<string>("F_UrlAddress");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_ModuleButton");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.ModuleEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("F_AllowDelete");

                    b.Property<bool?>("F_AllowEdit");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FullName");

                    b.Property<string>("F_Icon");

                    b.Property<bool?>("F_IsExpand");

                    b.Property<bool?>("F_IsMenu");

                    b.Property<bool?>("F_IsPublic");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<string>("F_ParentId");

                    b.Property<int?>("F_SortCode");

                    b.Property<string>("F_Target");

                    b.Property<string>("F_UrlAddress");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Module");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.OrganizeEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("F_Address");

                    b.Property<bool?>("F_AllowDelete");

                    b.Property<bool?>("F_AllowEdit");

                    b.Property<string>("F_AreaId");

                    b.Property<string>("F_CategoryId");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_Email");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_Fax");

                    b.Property<string>("F_FullName");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_Layers");

                    b.Property<string>("F_ManagerId");

                    b.Property<string>("F_MobilePhone");

                    b.Property<string>("F_ParentId");

                    b.Property<string>("F_ShortName");

                    b.Property<int?>("F_SortCode");

                    b.Property<string>("F_TelePhone");

                    b.Property<string>("F_WeChat");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Organize");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.RoleAuthorizeEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<string>("F_ItemId");

                    b.Property<int?>("F_ItemType");

                    b.Property<string>("F_ObjectId");

                    b.Property<int?>("F_ObjectType");

                    b.Property<int?>("F_SortCode");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_RoleAuthorize");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.RoleEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("F_AllowDelete");

                    b.Property<bool?>("F_AllowEdit");

                    b.Property<int?>("F_Category");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_EnCode");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FullName");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<string>("F_OrganizeId");

                    b.Property<int?>("F_SortCode");

                    b.Property<string>("F_Type");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Role");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.UserEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("F_Account");

                    b.Property<DateTime?>("F_Birthday");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_DepartmentId");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_DutyId");

                    b.Property<string>("F_Email");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<bool?>("F_Gender");

                    b.Property<string>("F_HeadIcon");

                    b.Property<bool?>("F_IsAdministrator");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<string>("F_ManagerId");

                    b.Property<string>("F_MobilePhone");

                    b.Property<string>("F_NickName");

                    b.Property<string>("F_OrganizeId");

                    b.Property<string>("F_RealName");

                    b.Property<string>("F_RoleId");

                    b.Property<int?>("F_SecurityLevel");

                    b.Property<string>("F_Signature");

                    b.Property<int?>("F_SortCode");

                    b.Property<string>("F_WeChat");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_User");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemManage.UserLogOnEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_AllowEndTime");

                    b.Property<DateTime?>("F_AllowStartTime");

                    b.Property<string>("F_AnswerQuestion");

                    b.Property<DateTime?>("F_ChangePasswordDate");

                    b.Property<bool?>("F_CheckIPAddress");

                    b.Property<DateTime?>("F_FirstVisitTime");

                    b.Property<string>("F_Language");

                    b.Property<DateTime?>("F_LastVisitTime");

                    b.Property<DateTime?>("F_LockEndDate");

                    b.Property<DateTime?>("F_LockStartDate");

                    b.Property<int?>("F_LogOnCount");

                    b.Property<bool?>("F_MultiUserLogin");

                    b.Property<DateTime?>("F_PreviousVisitTime");

                    b.Property<string>("F_Question");

                    b.Property<string>("F_Theme");

                    b.Property<string>("F_UserId");

                    b.Property<bool?>("F_UserOnLine");

                    b.Property<string>("F_UserPassword");

                    b.Property<string>("F_UserSecretkey");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_UserLogOn");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemSecurity.DbBackupEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_BackupTime");

                    b.Property<string>("F_BackupType");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<string>("F_DbName");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_FileName");

                    b.Property<string>("F_FilePath");

                    b.Property<string>("F_FileSize");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_SortCode");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_FilterIP");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemSecurity.FilterIPEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<bool?>("F_DeleteMark");

                    b.Property<DateTime?>("F_DeleteTime");

                    b.Property<string>("F_DeleteUserId");

                    b.Property<string>("F_Description");

                    b.Property<bool?>("F_EnabledMark");

                    b.Property<string>("F_EndIP");

                    b.Property<DateTime?>("F_LastModifyTime");

                    b.Property<string>("F_LastModifyUserId");

                    b.Property<int?>("F_SortCode");

                    b.Property<string>("F_StartIP");

                    b.Property<bool?>("F_Type");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_DbBackup");
                });

            modelBuilder.Entity("ZFine.Domain.Entity.SystemSecurity.LogEntity", b =>
                {
                    b.Property<string>("F_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("F_Account");

                    b.Property<DateTime?>("F_CreatorTime");

                    b.Property<string>("F_CreatorUserId");

                    b.Property<DateTime?>("F_Date");

                    b.Property<string>("F_Description");

                    b.Property<string>("F_IPAddress");

                    b.Property<string>("F_IPAddressName");

                    b.Property<string>("F_ModuleId");

                    b.Property<string>("F_ModuleName");

                    b.Property<string>("F_NickName");

                    b.Property<bool?>("F_Result");

                    b.Property<string>("F_Type");

                    b.HasKey("F_Id");

                    b.ToTable("Sys_Log");
                });
#pragma warning restore 612, 618
        }
    }
}
