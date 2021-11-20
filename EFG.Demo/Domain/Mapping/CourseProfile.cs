using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class CourseProfile
        : AutoMapper.Profile
    {
        public CourseProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.Course, ContosoUniversity.Domain.Models.CourseReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.CourseCreateModel, ContosoUniversity.Data.Entities.Course>();

            CreateMap<ContosoUniversity.Data.Entities.Course, ContosoUniversity.Domain.Models.CourseUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.CourseUpdateModel, ContosoUniversity.Data.Entities.Course>();

            CreateMap<ContosoUniversity.Domain.Models.CourseReadModel, ContosoUniversity.Domain.Models.CourseUpdateModel>();

        }

    }
}
