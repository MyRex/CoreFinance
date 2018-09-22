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
    public class ItemsDetailMap : Data.DBContext.EntityMappingConfiguration<ItemsDetailEntity>
    {
        public ItemsDetailMap()
        {
            
        }
        public override void Map(EntityTypeBuilder<ItemsDetailEntity> b)
        {
            b.ToTable("Sys_ItemsDetail");
            b.HasKey(t => t.F_Id);
        }
    }
}
