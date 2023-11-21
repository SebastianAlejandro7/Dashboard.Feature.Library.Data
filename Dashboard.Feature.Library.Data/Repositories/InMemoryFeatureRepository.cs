using Dashboard.Library.Model.Entities;

namespace Dashboard.Library.Data.Repositories;

public class InMemoryFeatureRepository : IFeatureRepository
{
    private static IDictionary<Guid, Feature> featuresDatabase;

    public InMemoryFeatureRepository()
    {
        featuresDatabase = new Dictionary<Guid, Feature>();
    }
    //funcion, tiene que devolver
    public Feature Create(Feature feature)
    {
        featuresDatabase.Add(feature.Id, feature);
        return feature;
	}

    public void Delete(Guid id)
    {
        featuresDatabase.Remove(id);
    }

    public List<Feature> Get()
    {
        return featuresDatabase.Values.ToList();
    }

    public Feature Get(Guid id)
    {
        featuresDatabase.TryGetValue(id, out Feature feature);

        return feature;
    }
    //procedimiento
    public void Update(Guid id, Feature feature)
    {
        if (featuresDatabase.ContainsKey(id))
        {
            featuresDatabase[id] = feature;
        }
        else
        {
            throw new KeyNotFoundException($"Feature with ID {id} not found");
        }
    }
}