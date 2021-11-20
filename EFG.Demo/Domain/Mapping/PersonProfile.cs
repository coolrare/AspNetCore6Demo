using System;
using AutoMapper;
using ContosoUniversity.Data.Entities;
using ContosoUniversity.Domain.Models;

namespace ContosoUniversity.Domain.Mapping
{
    public partial class PersonProfile
        : AutoMapper.Profile
    {
        public PersonProfile()
        {
            CreateMap<ContosoUniversity.Data.Entities.Person, ContosoUniversity.Domain.Models.PersonReadModel>();

            CreateMap<ContosoUniversity.Domain.Models.PersonCreateModel, ContosoUniversity.Data.Entities.Person>();

            CreateMap<ContosoUniversity.Data.Entities.Person, ContosoUniversity.Domain.Models.PersonUpdateModel>();

            CreateMap<ContosoUniversity.Domain.Models.PersonUpdateModel, ContosoUniversity.Data.Entities.Person>();

            CreateMap<ContosoUniversity.Domain.Models.PersonReadModel, ContosoUniversity.Domain.Models.PersonUpdateModel>();

        }

    }
}
