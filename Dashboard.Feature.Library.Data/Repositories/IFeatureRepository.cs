using Dashboard.Library.Model.Entities;

namespace Dashboard.Library.Data.Repositories
{
    public interface IFeatureRepository
    {
        Feature Create(Feature feature);

        List<Feature> Get();

        Feature Get(Guid id);

        void Delete(Guid id);

        void Update(Guid id, Feature feature);
    }
}
