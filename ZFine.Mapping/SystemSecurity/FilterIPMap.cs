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
    public class FilterIPMap : IEntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<FilterIPEntity> builder)
        {           
            builder.HasKey(t => t.F_Id);
        }

    }
}
