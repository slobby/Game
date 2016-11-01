using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Model
{
    class Staff: Container
    {
        public Staff(int id, IContainer parent):base (id, EntityType.WeaponStaff, parent)
        {
            Children = null;        
        } 

        public override void SetContainer(IContainer container)
        {
            throw new Exception();
        }

        public override ICollection<IContainer> GetContainers()
        {
            return Children;
        }

        public override void DeleteContainer(IContainer container)
        {
            throw new Exception();
        }

    }
}
