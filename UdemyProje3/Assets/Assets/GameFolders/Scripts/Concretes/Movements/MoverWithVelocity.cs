using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Controllers;
using UdemyProje3.Abstracts.Movements;
using UdemyProje3.Controllers;
using UnityEngine;

namespace UdemyProje3.Movements
{
    public class MoverWithVelocity : IMover
    {
        Rigidbody2D _rigidbody2D;
        float _moveSpeed;

        public MoverWithVelocity(PlayerController playerController, float moveSpeed)
        {
            _rigidbody2D = playerController.GetComponent<Rigidbody2D>();
            _moveSpeed = moveSpeed;
        }

        public void Tick(float horizontal)
        {
            if (horizontal != 0f || _rigidbody2D.velocity != Vector2.zero)
            {
                _rigidbody2D.velocity = new Vector2(horizontal * _moveSpeed * Time.fixedDeltaTime, _rigidbody2D.velocity.y);
            }
        }
    }
}

