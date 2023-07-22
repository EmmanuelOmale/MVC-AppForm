using Camp_for_Codes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Repository
{
    public interface IAppFormRepository
    {
        Task AddAsnswers(AppForm answers);
    }
}
