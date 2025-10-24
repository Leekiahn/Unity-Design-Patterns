using UnityEngine;

namespace FactoryMethod
{
    public abstract class BaseFactory : MonoBehaviour
    {
        public abstract BaseMonster SpawnMonster();
    }
}