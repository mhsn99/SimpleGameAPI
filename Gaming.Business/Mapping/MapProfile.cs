using AutoMapper;
using Gaming.Entities;
using Gaming.TransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.Business.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<Game, GameDisplayResponse>();
        }
    }
}
