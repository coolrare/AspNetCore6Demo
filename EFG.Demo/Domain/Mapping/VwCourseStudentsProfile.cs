using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class VwCourseStudentsProfile
        : AutoMapper.Profile
    {
        public VwCourseStudentsProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.VwCourseStudents, ContosoUniversity.Domain.Models.VwCourseStudentsReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentsCreateModel, ContosoUniversity.Data.Entities.VwCourseStudents>();

            CreateMap<ContosoUniversity.Data.Entities.VwCourseStudents, ContosoUniversity.Domain.Models.VwCourseStudentsUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentsUpdateModel, ContosoUniversity.Data.Entities.VwCourseStudents>();

            CreateMap<ContosoUniversity.Domain.Models.VwCourseStudentsReadModel, ContosoUniversity.Domain.Models.VwCourseStudentsUpdateModel>();

        }

    }
}
