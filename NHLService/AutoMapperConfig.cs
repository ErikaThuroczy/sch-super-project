using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLService
{
    static class AutoMapperConfig
    {
        public static void Init()
        {
            Mapper.CreateMap<Classes.MatchData, NHLService.MatchData>();
            Mapper.CreateMap<Classes.GlobalResults, NHLService.GlobalResults>();

            //.ForMember(dest=>dest.TeamName, opt=>opt.Ignore()
            //.ForMember(dest=>dest.TeamName, opt=>opt.Ignore()


            //tetszoleges tipusbol teszoleges tipusba masolja at a tulajdonsagokat ifvanilyentulajdosagakkorsetvalue -- reflection hf
        }
    }
}
