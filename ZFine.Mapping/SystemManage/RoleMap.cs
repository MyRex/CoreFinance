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
    public class RoleMap : Data.DBContext.EntityMappingConfiguration<RoleEntity>
    {
        public RoleMap()
        {
           
        }

        public override void Map(EntityTypeBuilder<RoleEntity> b)
        {
            b.ToTable("Sys_Role");
            b.HasKey(t => t.F_Id);
        }
    }
}
