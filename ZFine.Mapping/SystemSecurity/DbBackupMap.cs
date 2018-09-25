/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ZFine.Domain.Entity.SystemSecurity;

namespace ZFine.Mapping.SystemSecurity
{
    public class DbBackupMap : IEntityTypeConfiguration<DbBackupEntity>
    {

        public void Configure(EntityTypeBuilder<DbBackupEntity> builder)
        {
            builder.HasKey(t => t.F_Id);
        }
    }
}
