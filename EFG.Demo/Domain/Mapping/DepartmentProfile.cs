using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class DepartmentProfile
        : AutoMapper.Profile
    {
        public DepartmentProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.Department, ContosoUniversity.Domain.Models.DepartmentReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.DepartmentCreateModel, ContosoUniversity.Data.Entities.Department>();

            CreateMap<ContosoUniversity.Data.Entities.Department, ContosoUniversity.Domain.Models.DepartmentUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.DepartmentUpdateModel, ContosoUniversity.Data.Entities.Department>();

            CreateMap<ContosoUniversity.Domain.Models.DepartmentReadModel, ContosoUniversity.Domain.Models.DepartmentUpdateModel>();

        }

    }
}
