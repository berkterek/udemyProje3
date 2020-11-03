using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Combats;
using UnityEngine;

namespace UdemyProje3.Abstracts.Combats
{
    public abstract class Attacker : MonoBehaviour,IAttacker
    {
        [SerializeField] int damage = 1;

        public int Damage => damage;

        public virtual void Attack(ITakeHit takeHit)
        {
            takeHit.TakeHit(this);
        }
    }
}

