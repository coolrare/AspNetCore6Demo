using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Mapping
{
    public partial class CourseInstructorMap
        : IEntityTypeConfiguration<ContosoUniversity.Data.Entities.CourseInstructor>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContosoUniversity.Data.Entities.CourseInstructor> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("CourseInstructor", "dbo");

            // key
            builder.HasKey(t => new { t.CourseID, t.InstructorID });

            // properties
            builder.Property(t => t.CourseID)
                .IsRequired()
                .HasColumnName("CourseID")
                .HasColumnType("int");

            builder.Property(t => t.InstructorID)
                .IsRequired()
                .HasColumnName("InstructorID")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Course)
                .WithMany(t => t.CourseInstructors)
                .HasForeignKey(d => d.CourseID)
                .HasConstraintName("FK_dbo.CourseInstructor_dbo.Course_CourseID");

            builder.HasOne(t => t.InstructorPerson)
                .WithMany(t => t.InstructorCourseInstructors)
                .HasForeignKey(d => d.InstructorID)
                .HasConstraintName("FK_dbo.CourseInstructor_dbo.Instructor_InstructorID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "CourseInstructor";
        }

        public struct Columns
        {
            public const string CourseID = "CourseID";
            public const string InstructorID = "InstructorID";
        }
        #endregion
    }
}
