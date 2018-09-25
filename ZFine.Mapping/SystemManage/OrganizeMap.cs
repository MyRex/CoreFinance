/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZFine.Domain.Entity.SystemManage;

namespace ZFine.Mapping.SystemManage
{
    public class OrganizeMap : IEntityTypeConfiguration<OrganizeEntity>
    {
        public OrganizeMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<OrganizeEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        }

      
    }
}
