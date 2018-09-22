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
    public class RoleAuthorizeMap : Data.DBContext.EntityMappingConfiguration<RoleAuthorizeEntity>
    {
        public RoleAuthorizeMap()
        {
            
        }
        public override void Map(EntityTypeBuilder<RoleAuthorizeEntity> b)
        {
            b.ToTable("Sys_RoleAuthorize");
            b.HasKey(t => t.F_Id);
        }
    }
}
