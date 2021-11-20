using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Mapping
{
    public partial class VwCourseStudentCountMap
        : IEntityTypeConfiguration<ContosoUniversity.Data.Entities.VwCourseStudentCount>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContosoUniversity.Data.Entities.VwCourseStudentCount> builder)
        {
            #region Generated Configure
            // table
            builder.ToView("vwCourseStudentCount", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.DepartmentID)
                .HasColumnName("DepartmentID")
                .HasColumnType("int");

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.CourseID)
                .IsRequired()
                .HasColumnName("CourseID")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.StudentCount)
                .HasColumnName("StudentCount")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "vwCourseStudentCount";
        }

        public struct Columns
        {
            public const string DepartmentID = "DepartmentID";
            public const string Name = "Name";
            public const string CourseID = "CourseID";
            public const string Title = "Title";
            public const string StudentCount = "StudentCount";
        }
        #endregion
    }
}
