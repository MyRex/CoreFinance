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
    public class FilterIPMap : Data.DBContext.EntityMappingConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<FilterIPEntity> b)
        {
            b.ToTable("Sys_FilterIP");
            b.HasKey(t => t.F_Id);
        }
    }
}
