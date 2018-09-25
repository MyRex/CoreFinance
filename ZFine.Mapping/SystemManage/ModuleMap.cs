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
    public class ModuleMap : IEntityTypeConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<ModuleEntity> builder)
        {
            builder.HasKey(t => t.F_Id);

        }
    }
}
