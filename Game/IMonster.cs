﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTask
{
    public interface IMonster
    {
        int Health { get; set; }
        int Demage { get; set; }

        void MakeDemage();
    }
}