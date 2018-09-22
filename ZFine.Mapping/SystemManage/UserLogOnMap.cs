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
    public class UserLogOnMap : Data.DBContext.EntityMappingConfiguration<UserLogOnEntity>
    {
        public UserLogOnMap()
        {
           
        }

        public override void Map(EntityTypeBuilder<UserLogOnEntity> b)
        {
            b.ToTable("Sys_UserLogOn");
            b.HasKey(t => t.F_Id);
        }
    }
}
