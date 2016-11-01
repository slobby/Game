using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Model
{
    class Sword : Container
    {
        public Sword(int id, IContainer parent):base (id, EntityType.WeaponSword, parent)
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
