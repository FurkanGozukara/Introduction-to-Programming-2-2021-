﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace lecture_9
{
    [Table("tblLoginTry")]
    public partial class TblLoginTry
    {
        [Key]
        [StringLength(16)]
        public string TriedIp { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime DateOfTry { get; set; }
    }
}