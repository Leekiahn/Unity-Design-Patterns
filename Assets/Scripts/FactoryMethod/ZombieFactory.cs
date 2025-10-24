using UnityEngine;

namespace FactoryMethod
{
    public class ZombieFactory : GenericMonsterFactory<ZombieMonster>
    {
        public override BaseMonster SpawnMonster()
        {
            GameObject zombieObject = new GameObject("Zombie");
            ZombieMonster zombie = zombieObject.AddComponent<ZombieMonster>();
            return zombie;
        }
    }
}

