using System;
using UnityEngine;
using UnityEngine.UI;

public class SkeletonFactory : BaseFactory
{
    [SerializeField] private Button spawnButton;
    [SerializeField] private BaseMonster skeleton;

    private void Awake()
    {
        spawnButton.onClick.AddListener(() => SpawnMonster());
    }

    public override BaseMonster SpawnMonster()
    {
        Debug.Log("스켈레톤 팩토리에서 몬스터 생성");
        return Instantiate(skeleton);
    }
    
    private void OnDisable()
    {
        spawnButton.onClick.RemoveAllListeners();
    }
}
