using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JourneysApp.Models;

namespace JourneysApp.Services
{
    public class JourneysDbService : IJourneysDbService
    {
        private JourneysContext _dbContext;

        public JourneysDbService(JourneysContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Journey> GetAllJourneys()
        {
            return _dbContext.Journeys.Where(j => j.IsDeleted == false).ToList();
        }
    }
}