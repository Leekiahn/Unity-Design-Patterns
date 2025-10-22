using System;
using UnityEngine;

namespace SingletonPattern
{
    public class LazyInitSingleton : MonoBehaviour
    {
        private static LazyInitSingleton _instance = null;

        public static LazyInitSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("LazyInitSingleton");
                    _instance = singletonObject.AddComponent<LazyInitSingleton>();
                    DontDestroyOnLoad(singletonObject);
                    Debug.Log("LazyInitSingleton 인스턴스가 생성되었습니다.");
                }

                return _instance;
            }
        }

        public void CreateLazySingleton()
        {
            Debug.Log("LazyInitSingleton의 메서드가 호출되었습니다.");
        }
    }
}
