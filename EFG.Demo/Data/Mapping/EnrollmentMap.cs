using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Mapping
{
    public partial class EnrollmentMap
        : IEntityTypeConfiguration<ContosoUniversity.Data.Entities.Enrollment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContosoUniversity.Data.Entities.Enrollment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Enrollment", "dbo");

            // key
            builder.HasKey(t => t.EnrollmentID);

            // properties
            builder.Property(t => t.EnrollmentID)
                .IsRequired()
                .HasColumnName("EnrollmentID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CourseID)
                .IsRequired()
                .HasColumnName("CourseID")
                .HasColumnType("int");

            builder.Property(t => t.StudentID)
                .IsRequired()
                .HasColumnName("StudentID")
                .HasColumnType("int");

            builder.Property(t => t.Grade)
                .HasColumnName("Grade")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.Course)
                .WithMany(t => t.Enrollments)
                .HasForeignKey(d => d.CourseID)
                .HasConstraintName("FK_dbo.Enrollment_dbo.Course_CourseID");

            builder.HasOne(t => t.StudentPerson)
                .WithMany(t => t.StudentEnrollments)
                .HasForeignKey(d => d.StudentID)
                .HasConstraintName("FK_dbo.Enrollment_dbo.Person_StudentID");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Enrollment";
        }

        public struct Columns
        {
            public const string EnrollmentID = "EnrollmentID";
            public const string CourseID = "CourseID";
            public const string StudentID = "StudentID";
            public const string Grade = "Grade";
        }
        #endregion
    }
}
