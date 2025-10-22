using UnityEngine;

namespace DependencyInjection
{
    public class Sword : MonoBehaviour, IWeapon
    {
        public void Attack()
        {
            Debug.Log("검 공격!");
        }
    }
}
