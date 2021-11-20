using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class OfficeAssignmentProfile
        : AutoMapper.Profile
    {
        public OfficeAssignmentProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.OfficeAssignment, ContosoUniversity.Domain.Models.OfficeAssignmentReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.OfficeAssignmentCreateModel, ContosoUniversity.Data.Entities.OfficeAssignment>();

            CreateMap<ContosoUniversity.Data.Entities.OfficeAssignment, ContosoUniversity.Domain.Models.OfficeAssignmentUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.OfficeAssignmentUpdateModel, ContosoUniversity.Data.Entities.OfficeAssignment>();

            CreateMap<ContosoUniversity.Domain.Models.OfficeAssignmentReadModel, ContosoUniversity.Domain.Models.OfficeAssignmentUpdateModel>();

        }

    }
}
