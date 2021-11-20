using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data.Mapping
{
    public partial class PersonMap
        : IEntityTypeConfiguration<ContosoUniversity.Data.Entities.Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContosoUniversity.Data.Entities.Person> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Person", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.HireDate)
                .HasColumnName("HireDate")
                .HasColumnType("datetime");

            builder.Property(t => t.EnrollmentDate)
                .HasColumnName("EnrollmentDate")
                .HasColumnType("datetime");

            builder.Property(t => t.Discriminator)
                .IsRequired()
                .HasColumnName("Discriminator")
                .HasColumnType("nvarchar(128)")
                .HasMaxLength(128)
                .HasDefaultValueSql("('Instructor')");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "dbo";
            public const string Name = "Person";
        }

        public struct Columns
        {
            public const string Id = "ID";
            public const string LastName = "LastName";
            public const string FirstName = "FirstName";
            public const string HireDate = "HireDate";
            public const string EnrollmentDate = "EnrollmentDate";
            public const string Discriminator = "Discriminator";
        }
        #endregion
    }
}
