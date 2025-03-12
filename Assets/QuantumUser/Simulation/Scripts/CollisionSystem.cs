namespace Quantum
{
    using Photon.Deterministic;
    using UnityEngine.Scripting;

    [Preserve]
    public unsafe class CollisionSystem : SystemSignalsOnly, ISignalOnCollisionEnter2D
    {
        public void OnCollisionEnter2D(Frame frame, CollisionInfo2D info)
        {
            if (frame.TryGet<BulletInfo>(info.Entity, out var bulletInfo))
            {
                info.IgnoreCollision = true;
            }
        }
    }
}
