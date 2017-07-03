using JourneysApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneysApp.Services
{
    public interface IJourneysDbService
    {
        List<Journey> GetAllJourneys();
    }
}
