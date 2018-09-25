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
    public class AreaMap : IEntityTypeConfiguration<AreaEntity>
    {
        public void Configure(EntityTypeBuilder<AreaEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        } 
        
    }
}
