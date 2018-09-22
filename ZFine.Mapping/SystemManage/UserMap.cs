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
    public class UserMap : Data.DBContext.EntityMappingConfiguration<UserEntity>
    {
        public UserMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<UserEntity> b)
        {
            b.ToTable("Sys_User");
            b.HasKey(t => t.F_Id);
        }
    }
}
