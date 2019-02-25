using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CoreCodeCamp.Models;

namespace CoreCodeCamp.Data
{
    public class MyProfile : Profile
    {
        public MyProfile()
        {
            CreateMap<Camp, CampModel>().ReverseMap();
            CreateMap<Talk, TalkModel>().ReverseMap();
            CreateMap<Speaker, SpeakerModel>().ReverseMap();
        }

    }
}
