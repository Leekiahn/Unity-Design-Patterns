using UnityEngine;
using UnityEngine.UI;

namespace FactoryMethod
{
    public class GenericMonsterFactory<T> : BaseFactory where T : BaseMonster
    {
        [SerializeField] private T monsterPrefab;
        [SerializeField] private Button spawnButton;


        private void Awake()
        {
            if (spawnButton != null)
            {
                spawnButton.onClick.AddListener(() => SpawnMonster());
            }
        }

        public override BaseMonster SpawnMonster()
        {
            if (monsterPrefab == null)
            {
                Debug.LogError($"{typeof(T).Name} 프리팹이 할당되지 않았습니다!");
                return null;
            }

            Debug.Log($"{typeof(T).Name} 팩토리에서 몬스터 생성");
            return Instantiate(monsterPrefab);
        }

        private void OnDisable()
        {
            spawnButton.onClick.RemoveAllListeners();
        }
    }
}