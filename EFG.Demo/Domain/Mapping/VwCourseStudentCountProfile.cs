using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class VwCourseStudentCountProfile
        : AutoMapper.Profile
    {
        public VwCourseStudentCountProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.VwCourseStudentCount, ContosoUniversity.Domain.Models.VwCourseStudentCountReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentCountCreateModel, ContosoUniversity.Data.Entities.VwCourseStudentCount>();

            CreateMap<ContosoUniversity.Data.Entities.VwCourseStudentCount, ContosoUniversity.Domain.Models.VwCourseStudentCountUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentCountUpdateModel, ContosoUniversity.Data.Entities.VwCourseStudentCount>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentCountReadModel, ContosoUniversity.Domain.Models.VwCourseStudentCountUpdateModel>();

        }

    }
}
