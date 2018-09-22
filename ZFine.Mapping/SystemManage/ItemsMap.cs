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
    public class ItemsMap : Data.DBContext.EntityMappingConfiguration<ItemsEntity>
    {
        public ItemsMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<ItemsEntity> b)
        {
            b.ToTable("Sys_Items");
            b.HasKey(t => t.F_Id);
        }
    }
}
