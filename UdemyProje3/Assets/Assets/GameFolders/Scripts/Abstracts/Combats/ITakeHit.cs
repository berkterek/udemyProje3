using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje3.Abstracts.Combats
{
    public interface ITakeHit
    {
        void TakeHit(IAttacker attacker);
    }
}

