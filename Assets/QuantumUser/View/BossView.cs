namespace Quantum
{
    using UnityEngine;

    public class BossView : QuantumEntityViewComponent
    {
        public Quaternion rotationLeft;
        public Quaternion rotationRight;
        public Transform visual;
        private PhysicsBody2D body;

        private void Update()
        {
            if (VerifiedFrame.TryGet<PhysicsBody2D>(_entityView.EntityRef, out body))
            {
                if (body.Velocity.X < 0)
                {
                    visual.rotation = rotationLeft;
                }
                else if (body.Velocity.X > 0)
                {
                    visual.rotation = rotationRight;
                }
            }
        }
    }
}
