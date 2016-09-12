using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTask
{
    public class Monster : GameObject, IMovingObject
    {
        public virtual void Move() { }
        public void EatPlayer() { }
    }
}
