using AutoMapper;
using Classes;
using Entities;
using Repository.ResultRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NHLService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class NHLStatService : INHLStatService
    {
        IResultRepository repo;
        public NHLStatService()
        {
            AutoMapperConfig.Init();
            TeamDBEntities te = new TeamDBEntities();
            repo = new ResultRepository(te);
        }

        public List<MatchData> GetAllMatches()
        {
            return repo.GetAllMatches().Select(x => Mapper.Map<Classes.MatchData, NHLService.MatchData>(x)).ToList();
        }

        public List<GlobalResults> GetAllResults()
        {
            return repo.GetAllResults().Select(x => Mapper.Map<Classes.GlobalResults, NHLService.GlobalResults>(x)).ToList();
        }
    }
}
