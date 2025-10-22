using UnityEngine;

// 즉시 초기화 싱글톤 패턴 구현
public class EagerInitSingleton : MonoBehaviour
{
    private static EagerInitSingleton _instance = null;
    public static EagerInitSingleton Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("EagerInitSingleton 인스턴스가 존재하지 않습니다.");
            }
            return _instance;
        }
    }
    
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            Debug.Log("EagerInitSingleton 인스턴스가 생성되었습니다.");
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
            Debug.LogWarning("EagerInitSingleton 인스턴스가 이미 존재하여 새로 생성된 인스턴스를 파괴합니다.");
        }
    }
}
