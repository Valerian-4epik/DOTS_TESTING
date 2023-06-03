using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace CodeMonkey
{
    public partial struct MovingSystemBase : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState systemState)
        {
            foreach (var transform in SystemAPI.Query<RefRW<LocalTransform>>())
            {
                transform.ValueRW.Position += new float3(SystemAPI.Time.DeltaTime, 0, 0);
            }
        }
    }
}