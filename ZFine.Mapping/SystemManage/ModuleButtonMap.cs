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
    public class ModuleButtonMap : Data.DBContext.EntityMappingConfiguration<ModuleButtonEntity>
    {
        public ModuleButtonMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<ModuleButtonEntity> b)
        {
            b.ToTable("Sys_ModuleButton");
            b.HasKey(t => t.F_Id);
        }
    }
}
