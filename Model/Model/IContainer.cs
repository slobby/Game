using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Model
{
    public interface IContainer
    {
        int? Id { get; }
        IContainer Parent { get; set; }
        EntityType TypeContainer { get; }

        void SetContainer(IContainer container);
        ICollection<IContainer> GetContainers();
        void DeleteContainer(IContainer container);




    }
}
