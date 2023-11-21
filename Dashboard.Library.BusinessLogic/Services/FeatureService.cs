using Dashboard.Library.BusinessLogic.Contracts;
using Dashboard.Library.Data.Repositories;
using Dashboard.Library.Model.Entities;

namespace Dashboard.Library.BusinessLogic.Services;

public class FeatureService : IFeatureService
{
    public List<Feature> GetFeaturesByUserId(Guid userId)
    {
        IFeatureRepository featureRepository = new InMemoryFeatureRepository();

        IUserRepository userRepository;

        User user = userRepository.Get(userId);

        if (user == null)
        {
            throw new ArgumentException("User does not exist!");
        }        

        var features = featureRepository.Get();

        var featuresToReturn = new List<Feature>();

        foreach(Feature f in features)
        {
            if (f.User != null && f.User == user)
            {
				featuresToReturn.Add(f);
			}
        }

        return featuresToReturn;       
    }

    public void SetTaskAsCompleted(Guid taskId)
    {
        throw new NotImplementedException();
    }



}