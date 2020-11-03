using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Controllers;
using UdemyProje3.Abstracts.Movements;
using UdemyProje3.Controllers;
using UnityEngine;

namespace UdemyProje3.Movements
{
    public class MoverWithTranslate : IMover
    {
        IEntityController _controller;
        
        float _moveSpeed;

        public MoverWithTranslate(IEntityController controller, float moveSpeed)
        {
            _controller = controller;
            _moveSpeed = moveSpeed;
        }

        public void Tick(float horizontal)
        {
            if (horizontal == 0f) return;

            _controller.transform.Translate(Vector2.right * horizontal * Time.deltaTime * _moveSpeed);
        }
    }
}

