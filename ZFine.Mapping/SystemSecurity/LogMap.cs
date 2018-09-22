/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZFine.Domain.Entity.SystemSecurity;

namespace ZFine.Mapping.SystemSecurity
{
    public class LogMap : Data.DBContext.EntityMappingConfiguration<LogEntity>
    {
        public LogMap()
        {
           
        }

        public override void Map(EntityTypeBuilder<LogEntity> b)
        {
            b.ToTable("Sys_Log");
            b.HasKey(t => t.F_Id);
        }
    }
}
