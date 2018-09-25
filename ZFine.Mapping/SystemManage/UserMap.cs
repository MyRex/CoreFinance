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
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public UserMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        }
    }
}
