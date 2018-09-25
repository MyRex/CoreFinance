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
    public class ModuleButtonMap : IEntityTypeConfiguration<ModuleButtonEntity>
    {
        public ModuleButtonMap()
        {
            
        }

        public void Configure(EntityTypeBuilder<ModuleButtonEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        }

       
    }
}
