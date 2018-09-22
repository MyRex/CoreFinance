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
    public class ModuleMap : Data.DBContext.EntityMappingConfiguration<ModuleEntity>
    {
        public ModuleMap()
        {
            
        }

        public override void Map(EntityTypeBuilder<ModuleEntity> b)
        {
            b.ToTable("Sys_Module");
            b.HasKey(t => t.F_Id);
        }
    }
}
