using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Movements;
using UnityEngine;

namespace UdemyProje3.Movements
{
    public class JumpMulti : IJump
    {
        Rigidbody2D _rigidbody;
        IOnGround _onGround;

        float _jumpForce = 350f;
        int _maxJumpCount = 2;
        int _currentJumpCount = 0;

        public bool IsJump { get; set; }

        public JumpMulti(Rigidbody2D rigidbody, IOnGround onGround)
        {
            _rigidbody = rigidbody;
            _onGround = onGround;
        }

        public void TickWithFixedUpdate()
        {
            if (IsJump)
            {
                if (_currentJumpCount < _maxJumpCount)
                {
                    _rigidbody.velocity = Vector2.zero;

                    _rigidbody.AddForce(Vector2.up * _jumpForce);

                    _rigidbody.velocity = Vector2.zero;
                    _currentJumpCount++;
                }
                else if (_onGround.IsGround)
                {
                    IsJump = false;
                    _currentJumpCount = 0;
                }
            }

        }
    }
}

