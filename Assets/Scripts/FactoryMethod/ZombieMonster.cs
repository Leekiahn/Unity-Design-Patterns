using UnityEngine;

public class ZombieMonster : BaseMonster
{
    void OnEnable()
    {
        Debug.Log("좀비 몬스터가 생성되었습니다!");
    }
    
    public override void Attack()
    {
        Debug.Log("좀비가 공격합니다!");
    }
}
