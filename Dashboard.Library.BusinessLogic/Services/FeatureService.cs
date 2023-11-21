using Dashboard.Library.BusinessLogic.Contracts;
using Dashboard.Library.Data.Repositories;
using Dashboard.Library.Model.Entities;

namespace Dashboard.Library.BusinessLogic.Services;

public class FeatureService : IFeatureService
{
    private readonly IFeatureRepository _featureRepository;
    private readonly IUserRepository _userRepository;

	public FeatureService(IFeatureRepository featureRepository, IUserRepository userRepository)
	{
		_featureRepository = featureRepository;
		_userRepository = userRepository;
	}

	public List<Feature> GetFeaturesByUserId(Guid userId)
    {
        User user = _userRepository.Get(userId);

        if (user == null)
        {
            throw new ArgumentException("User does not exist!");
        }        

        var features = _featureRepository.Get();

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