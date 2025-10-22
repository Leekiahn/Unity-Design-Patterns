using UnityEngine;

namespace DependencyInjection
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public void Attack()
        {
            Debug.Log("총 발사!");
        }
    }
}