using UnityEngine;

namespace DependencyInjection
{
    public class Grenade : MonoBehaviour,IWeapon
    {
        public void Attack()
        {
            Debug.Log("수류탄 투척!");
        }
    }
}

