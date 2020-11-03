using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje3.Abstracts.Inputs
{
    public interface IPlayerInput
    {
        float Horizontal { get; }
        float Vertical { get; }
        bool JumpButtonDown { get; }
        bool AttackButtonDown { get; }
    }
}

