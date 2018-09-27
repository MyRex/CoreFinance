/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZFine.Data.DBContext
{
    [Table("FilterIP")]
    public class FilterIPEntity
    {
        [Key]
        public int Id { get; set; }
        public long Number { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
