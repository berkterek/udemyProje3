using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Animations;
using UdemyProje3.Abstracts.Controllers;
using UdemyProje3.Abstracts.Movements;
using UdemyProje3.Abstracts.StateMachines;
using UnityEngine;

namespace UdemyProje3.StateMachines.EnemyStates
{
    public class Idle : IState
    {
        IMover _mover;
        IMyAnimation _animation;

        float _maxStandTime;
        float _currentStandTime = 0f;

        public bool IsIdle { get; private set; }

        public Idle(IMover mover,IMyAnimation animation)
        {
            _mover = mover;
            _animation = animation;
        }

        public void OnEnter()
        {
            IsIdle = true;
            _animation.MoveAnimation(0f);

            _maxStandTime = Random.Range(4f, 10f);
        }

        public void OnExit()
        {
            _currentStandTime = 0f;
        }

        public void Tick()
        {
            _mover.Tick(0f);

            _currentStandTime += Time.deltaTime;

            if (_currentStandTime > _maxStandTime)
            {
                IsIdle = false;
            }

            Debug.Log("Idle Tick");
        }
    }
}

