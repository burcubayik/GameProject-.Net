﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    internal interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
