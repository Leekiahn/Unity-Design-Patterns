using UnityEngine;

namespace SingletonPattern
{
    public class LazySingletonButton : MonoBehaviour
    {
        public void OnButtonClick()
        {
            LazyInitSingleton.Instance.CreateLazySingleton();
            // LazyInitSingleton 인스턴스 생성 및 메서드 호출
        }
    }
}
