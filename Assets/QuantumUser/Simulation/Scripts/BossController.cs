namespace Quantum
{
    using Photon.Deterministic;
    using UnityEngine.Scripting;

    [Preserve]
    public unsafe class BossController : SystemMainThreadFilter<BossController.Filter>
    {
        public struct Filter
        {
            public EntityRef Entity;
            public PhysicsBody2D* Body;
            public BossInfo* BossInfo;
        }
        public override void Update(Frame frame, ref Filter filter)
        {
            filter.BossInfo->Time += frame.DeltaTime;
            if (filter.BossInfo->Time > filter.BossInfo->ChangeDirectionTime)
            {
                filter.BossInfo->ChangeDirectionTime = filter.BossInfo->Time + frame.Global->RngSession.Next(FP._2, FP._3);
                filter.BossInfo->Direction = new FPVector2(frame.Global->RngSession.Next(-FP._1, FP._1), frame.Global->RngSession.Next(-FP._1, FP._1)).Normalized;
            }

            filter.Body->Velocity = filter.BossInfo->Direction;
        }

        
    }
}
