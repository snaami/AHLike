using UnityEngine;

namespace AHLike.Movement
{
    internal class KeyboarInput : MovementInput
    {
        protected override Vector3 DetectMovementDirection()
        {
            _movementDirection.x = Input.GetAxisRaw("Horizontal");
            _movementDirection.z = Input.GetAxisRaw("Vertical");
            return _movementDirection;
        }
    }
}