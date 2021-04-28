﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace lecture_9
{
    [Table("tblDiseases")]
    public partial class TblDiseases
    {
        public TblDiseases()
        {
            TblTreatments = new HashSet<TblTreatments>();
        }

        [Key]
        public int DiseaseId { get; set; }
        [Required]
        [StringLength(200)]
        public string DiseaseName { get; set; }
        [Required]
        public string DiseaseDescription { get; set; }

        [InverseProperty("Disease")]
        public virtual ICollection<TblTreatments> TblTreatments { get; set; }
    }
}