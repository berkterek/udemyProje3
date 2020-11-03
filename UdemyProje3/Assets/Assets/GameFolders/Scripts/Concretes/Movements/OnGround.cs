using System.Collections;
using System.Collections.Generic;
using UdemyProje3.Abstracts.Movements;
using UnityEngine;

namespace UdemyProje3.Movements
{
    public class OnGround : MonoBehaviour,IOnGround
    {
        [SerializeField] Transform[] transforms;
        [SerializeField] float maxDistance = 0.3f;
        [SerializeField] LayerMask layerMask;

        bool _isGround;
        public bool IsGround => _isGround;

        private void Update()
        {
            foreach (Transform footTransform in transforms)
            {
                CheckIfFootsOnGround(footTransform);

                if (_isGround) break;
            }
        }

        private void CheckIfFootsOnGround(Transform footTransform)
        {
            RaycastHit2D hit = Physics2D.Raycast(footTransform.position, footTransform.forward, maxDistance, layerMask);
            Debug.DrawRay(footTransform.position, footTransform.forward * maxDistance, Color.red);

            if (hit.collider != null)
            {
                _isGround = true;
            }
            else
            {
                _isGround = false;
            }
        }
    }
}

