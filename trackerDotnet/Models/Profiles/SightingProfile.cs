using AutoMapper;
using trackerDotnet.Models.Domain;
using trackerDotnet.Models.DTO.Sighting;
using System.Linq;

namespace trackerDotnet.Models.Profiles
{
    public class SightingProfile : Profile
    {
        public SightingProfile()
        {
            CreateMap<Sighting, SightingReadDTO>();

            CreateMap<SightingCreateDTO, Sighting>();

            CreateMap<SightingEditDTO, Sighting>();
        }
    }
}
