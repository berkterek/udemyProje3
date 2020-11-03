using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Movements;
using UdemyProje3.Controllers;
using UnityEngine;

namespace UdemyProje3.Movements
{
    public class FlipWithSpriteRender : IFlip
    {
        SpriteRenderer _spriteRender;

        public FlipWithSpriteRender(PlayerController player)
        {
            _spriteRender = player.GetComponentInChildren<SpriteRenderer>();
        }

        public void FlipCharacter(float direction)
        {
            if (direction == 0f) return;

            if (direction < 0f)
            {
                _spriteRender.flipX = true;
            }
            else
            {
                _spriteRender.flipX = false;
            }
        }
    }
}

