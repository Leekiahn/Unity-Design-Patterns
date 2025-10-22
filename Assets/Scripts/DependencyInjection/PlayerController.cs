using UnityEngine;

namespace DependencyInjection
{
    public class PlayerController : MonoBehaviour
    {
        public void Attack(IWeapon weapon)
        {
            weapon.Attack();
        }
    }
}