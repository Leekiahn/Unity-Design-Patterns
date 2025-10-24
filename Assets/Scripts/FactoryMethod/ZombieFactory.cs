using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ZombieFactory : BaseFactory
{
    [SerializeField] private Button spawnButton;
    [SerializeField] private BaseMonster zombie;
    
    private void Awake()
    {
        spawnButton.onClick.AddListener(() => SpawnMonster());
    }
    
    public override BaseMonster SpawnMonster()
    {
        Debug.Log("좀비 팩토리에서 몬스터 생성");
        return Instantiate(zombie);
    }

    private void OnDisable()
    {
        spawnButton.onClick.RemoveAllListeners();
    }
}
