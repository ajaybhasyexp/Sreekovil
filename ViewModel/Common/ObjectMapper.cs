using DivineAccounts.Model.Models.Base;
using System.Collections.Generic;

namespace ViewModel.Common
{
    public abstract class ObjectMapper<TEntity, TObject>
        where TEntity : IEntity
        where TObject : class, new()
    {
        protected ObjectMapper()
        {

        }

        public abstract TObject ToObject(TEntity entity);

        public abstract TEntity ToEntity(TObject value);

        public IEnumerable<TObject> ToObjects(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                yield return ToObject(entity);
            }
        }

        public IEnumerable<TEntity> ToEntities(IEnumerable<TObject> items)
        {
            foreach (var item in items)
            {
                yield return ToEntity(item);
            }
        }

        public abstract bool Validate();
    }
}
