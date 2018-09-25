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
    public class ItemsDetailMap : IEntityTypeConfiguration<ItemsDetailEntity>
    {
        public ItemsDetailMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<ItemsDetailEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        }

        
    }
}
