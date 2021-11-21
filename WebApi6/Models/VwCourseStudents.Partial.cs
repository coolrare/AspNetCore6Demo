using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApi6.Models
{
    [ModelMetadataType(typeof(VwCourseStudentsMetadata))]
    public partial class VwCourseStudents
    {
    }

    internal class VwCourseStudentsMetadata
    {
        // [Required]
        public Nullable<Int32> DepartmentId { get; set; }
        // [Required]
        public String DepartmentName { get; set; }
        // [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public String CourseTitle { get; set; }
        // [Required]
        public Nullable<Int32> StudentId { get; set; }
        // [Required]
        public String StudentName { get; set; }
    }
}
