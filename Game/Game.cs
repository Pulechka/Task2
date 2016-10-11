using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public sealed class Game
    {
        public bool IsAllBonusTaken { get; set; }

        public bool IsMonsterEatPlayer { get; set; }

        public void Start() { }

        public void Pause() { }

        public void Finish() { }
    }
}
