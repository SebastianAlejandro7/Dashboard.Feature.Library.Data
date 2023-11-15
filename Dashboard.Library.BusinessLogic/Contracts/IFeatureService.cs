using Dashboard.Library.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Library.BusinessLogic.Contracts
{
    internal interface IFeatureService
    {
        //Description
        List<Feature> GetFeaturesByUserId(Guid userId);
        void SetTaskAsCompleted(Guid taskId);
    }
}
