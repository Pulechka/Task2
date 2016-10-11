using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTask
{
    public abstract class Monster : GameObject, IMonster, IMovable
    {
        private int health;
        private int demage;

        public virtual int Health { get; }
        public virtual int Demage { get; }

        public virtual void Atack()
        {
            throw new NotImplementedException();
        }

        public virtual void MoveDown()
        {
            throw new NotImplementedException();
        }

        public virtual void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public virtual void MoveRight()
        {
            throw new NotImplementedException();
        }

        public virtual void MoveUp()
        {
            throw new NotImplementedException();
        }
    }
}
