/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection;

namespace ZFine.Data
{

    public class ZFineDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        //public virtual DbSet<FilterIPEntity> FilterIPEntitys { get; set; }
        public ZFineDbContext()
        { }
        public ZFineDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }        

        public ZFineDbContext(DbContextOptions<ZFineDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseMySql("server=localhost;database=tt;user id=root;password=sa395864@007;SslMode=none;");//配置连接字符串
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
            //assembleFileName = assembleFileName.Replace("ZFine.Domain.dll", "ZFine.Mapping.dll");
            //asm = Assembly.LoadFile(assembleFileName);
            //var typesMapToRegister = asm.ExportedTypes;

            //foreach (var type in typesMapToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.ApplyConfiguration(configurationInstance);
            //}


        }
    }
}
