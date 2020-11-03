using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Animations;
using UdemyProje3.Abstracts.Controllers;
using UdemyProje3.Abstracts.Movements;
using UdemyProje3.Abstracts.StateMachines;
using UnityEngine;

namespace UdemyProje3.StateMachines.EnemyStates
{
    public class ChasePlayer : IState
    {
        IMover _mover;
        IFlip _flip;
        IMyAnimation _animation;
        IStopEdge _stopEdge;
        System.Func<bool> _isPlayerRightSide;

        public ChasePlayer(IMover mover, IFlip flip, IMyAnimation animation,IStopEdge stopEdge, System.Func<bool> isPlayerRightSide)
        {
            _mover = mover;
            _flip = flip;
            _animation = animation;
            _stopEdge = stopEdge;
            _isPlayerRightSide = isPlayerRightSide;
        }

        public void OnEnter()
        {
            _animation.MoveAnimation(1f);
        }

        public void OnExit()
        {
            _animation.MoveAnimation(0f);
        }

        public void Tick()
        {
            if (_stopEdge.ReachEdge())
            {
                _animation.MoveAnimation(0f);
                return;
            }

            if (_isPlayerRightSide.Invoke())
            {
                _mover.Tick(1.5f);
                _flip.FlipCharacter(1f);
            }
            else
            {
                _mover.Tick(-1.5f);
                _flip.FlipCharacter(-1f);
            }

            Debug.Log("Chase Player Tick");
        }
    }
}

