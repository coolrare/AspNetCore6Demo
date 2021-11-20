using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class EnrollmentProfile
        : AutoMapper.Profile
    {
        public EnrollmentProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.Enrollment, ContosoUniversity.Domain.Models.EnrollmentReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.EnrollmentCreateModel, ContosoUniversity.Data.Entities.Enrollment>();

            CreateMap<ContosoUniversity.Data.Entities.Enrollment, ContosoUniversity.Domain.Models.EnrollmentUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.EnrollmentUpdateModel, ContosoUniversity.Data.Entities.Enrollment>();

            CreateMap<ContosoUniversity.Domain.Models.EnrollmentReadModel, ContosoUniversity.Domain.Models.EnrollmentUpdateModel>();

        }

    }
}
