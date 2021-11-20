using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class CourseInstructorProfile
        : AutoMapper.Profile
    {
        public CourseInstructorProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.CourseInstructor, ContosoUniversity.Domain.Models.CourseInstructorReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.CourseInstructorCreateModel, ContosoUniversity.Data.Entities.CourseInstructor>();

            CreateMap<ContosoUniversity.Data.Entities.CourseInstructor, ContosoUniversity.Domain.Models.CourseInstructorUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.CourseInstructorUpdateModel, ContosoUniversity.Data.Entities.CourseInstructor>();

            CreateMap<ContosoUniversity.Domain.Models.CourseInstructorReadModel, ContosoUniversity.Domain.Models.CourseInstructorUpdateModel>();

        }

    }
}
