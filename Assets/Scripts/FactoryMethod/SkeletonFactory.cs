using UnityEngine;

namespace FactoryMethod
{
    public class SkeletonFactory : GenericMonsterFactory<SkeletonMonster>
    {
        public override BaseMonster SpawnMonster()
        {
            GameObject skeletonObject = new GameObject("Skeleton");
            SkeletonMonster skeleton = skeletonObject.AddComponent<SkeletonMonster>();
            return skeleton;
        }
    }
}

