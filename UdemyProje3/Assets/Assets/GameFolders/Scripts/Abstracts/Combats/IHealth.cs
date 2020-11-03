using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje3.Abstracts.Combats
{
    public interface IHealth : ITakeHit
    {
        bool IsDead { get; }
        void Heal(int lifeCount);
        event System.Action<int,int> OnHealthChanged;
        event System.Action OnDead;
    }
}

