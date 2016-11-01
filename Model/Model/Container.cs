using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Model
{
    public abstract class Container : IContainer
    {
        int? id = null;
        EntityType entityType = default(EntityType);
        protected List<IContainer> Children = new List<IContainer>();

        public Container(int id, EntityType entityType, IContainer parent)
        {
            this.id = id;
            this.entityType = entityType;
            Parent = parent;
        }
         
        public int? Id
        {
            get
            {
                return id;
            }
        }

        public IContainer Parent
        { get; set; }

        public EntityType TypeContainer
        {
            get
            {
                return entityType;
            }
        }

        public abstract void SetContainer(IContainer container);
        public abstract ICollection<IContainer> GetContainers();
        public abstract void DeleteContainer(IContainer container);
    }
}
