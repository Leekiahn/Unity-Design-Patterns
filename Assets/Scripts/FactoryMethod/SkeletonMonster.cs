using System;
using UnityEngine;

namespace FactoryMethod
{
    public class SkeletonMonster : BaseMonster
    {
        private void OnEnable()
        {
            Debug.Log("스켈레톤 몬스터가 생성되었습니다!");
        }

        public override void Attack()
        {
            Debug.Log("스켈레톤이 공격합니다!");
        }
    }
}