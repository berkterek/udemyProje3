using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProje3.Abstracts.Movements
{
    public interface IJump
    {
        void TickWithFixedUpdate();
        bool IsJump { get; set; }
    }
}

