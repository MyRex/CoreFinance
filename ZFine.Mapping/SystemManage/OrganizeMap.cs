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
    public class OrganizeMap : Data.DBContext.EntityMappingConfiguration<OrganizeEntity>
    {
        public OrganizeMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<OrganizeEntity> b)
        {
            b.ToTable("Sys_Organize");
            b.HasKey(t => t.F_Id);
        }
    }
}
