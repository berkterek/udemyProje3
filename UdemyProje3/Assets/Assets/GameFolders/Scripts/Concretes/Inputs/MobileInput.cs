using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Inputs;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UdemyProje3.Inputs
{
    public class MobileInput : IPlayerInput
    {
        public float Horizontal => CrossPlatformInputManager.GetAxis("Horizontal");

        public float Vertical => CrossPlatformInputManager.GetAxis("Vertical");

        public bool JumpButtonDown => CrossPlatformInputManager.GetButtonDown("Jump");

        public bool AttackButtonDown => CrossPlatformInputManager.GetButtonDown("Fire1");
    }
}

