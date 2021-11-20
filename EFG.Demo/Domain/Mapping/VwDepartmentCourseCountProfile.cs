using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class VwDepartmentCourseCountProfile
        : AutoMapper.Profile
    {
        public VwDepartmentCourseCountProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.VwDepartmentCourseCount, ContosoUniversity.Domain.Models.VwDepartmentCourseCountReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwDepartmentCourseCountCreateModel, ContosoUniversity.Data.Entities.VwDepartmentCourseCount>();

            CreateMap<ContosoUniversity.Data.Entities.VwDepartmentCourseCount, ContosoUniversity.Domain.Models.VwDepartmentCourseCountUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwDepartmentCourseCountUpdateModel, ContosoUniversity.Data.Entities.VwDepartmentCourseCount>();

            CreateMap<ContosoUniversity.Domain.Models.VwDepartmentCourseCountReadModel, ContosoUniversity.Domain.Models.VwDepartmentCourseCountUpdateModel>();

        }

    }
}
