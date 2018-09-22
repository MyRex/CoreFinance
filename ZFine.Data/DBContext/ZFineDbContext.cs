/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using System;

using System.Linq;
using System.Reflection;

namespace ZFine.Data
{
   
    public class ZFineDbContext : DbContext
    {
        public string ConnectionString { get; set; }

        //public ZFineDbContext(string connectionString)
        //{
        //    this.ConnectionString = connectionString;
        //}
        //public DbSet<LogEntity> LogEntitys { get; set; }

        //public ZFineDbContext(DbContextOptions<ZFineDbContext> options)
        //    : base(options)
        //{
        //    //this.Configuration.AutoDetectChangesEnabled = false;
        //    //this.Configuration.ValidateOnSaveEnabled = false;
        //    //this.Configuration.LazyLoadingEnabled = false;
        //    //this.Configuration.ProxyCreationEnabled = false;
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("Data Source=localhost;Database=zfine;User ID=root;Password=sa395864@007;pooling=true;CharSet=utf8;port=3306;sslmode=none");//配置连接字符串
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("ZFine.Data.dll", "ZFine.Domain.dll").Replace("file:///", "");
            Assembly asm = Assembly.LoadFile(assembleFileName);
            var typesToRegister = asm.GetTypes()
            .Where(gi => gi.FullName.Contains("ZFine.Domain.Entity")).ToList();
            //Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

            foreach (var entityType in typesToRegister)
            {
                //  防止重复附加模型，否则会在生成指令中报错
                if (modelBuilder.Model.FindEntityType(entityType) != null)
                    continue;

                modelBuilder.Model.AddEntityType(entityType);
            }
            assembleFileName.Replace("ZFine.Data.dll", "ZFine.Mapping.dll");
            asm = Assembly.LoadFile(assembleFileName);
            var typesMapToRegister = asm.ExportedTypes;

            foreach (var type in typesMapToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
            
            
        }
    }
}
