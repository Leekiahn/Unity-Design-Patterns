using UnityEngine;
using UnityEngine.UI;

public class DIController : MonoBehaviour
{
    private Button _swordButton;
    private Button _gunButton;
    private Button _grenadeButton;
    
    private IWeapon _currentWeapon;
    private Sword _sword;
    private Gun _gun;
    private Grenade _grenade;
    
    private PlayerController _player;

    private void Awake()
    {
        _sword = GetComponentInChildren<Sword>();
        if(_sword == null) { Debug.LogError("Sword 컴포넌트를 가진 하위 오브젝트를 찾을 수 없음"); return;}
        _gun = GetComponentInChildren<Gun>();
        if(_gun == null) { Debug.LogError("Gun 컴포넌트를 가진 하위 오브젝트를 찾을 수 없음"); return;}
        _grenade = GetComponentInChildren<Grenade>();
        if(_grenade == null) { Debug.LogError("Grenade 컴포넌트를 가진 하위 오브젝트를 찾을 수 없음"); return;}

        if (!_sword.gameObject.TryGetComponent(out _swordButton))
        {
            Debug.LogError("Sword Button 컴포넌트를 찾을 수 없습니다.");
            return;
        }
        else{ _swordButton.onClick.AddListener(OnSwordButtonClicked); }
        
        if (!_gun.gameObject.TryGetComponent(out _gunButton))
        {
            Debug.LogError("Gun Button 컴포넌트를 찾을 수 없습니다.");
            return;
        }
        else{ _gunButton.onClick.AddListener(OnGunButtonClicked); }
        
        if (!_grenade.gameObject.TryGetComponent(out _grenadeButton))
        {
            Debug.LogError("Grenade Button 컴포넌트를 찾을 수 없습니다.");
            return;
        }
        else{ _grenadeButton.onClick.AddListener(OnGrenadeButtonClicked); }

        _player = FindAnyObjectByType<PlayerController>();
        if(_player == null) { Debug.LogError("씬에서 PlayerController 컴포넌트를 찾을 수 없습니다.");}
    }
    
    private void OnSwordButtonClicked()
    {
        _currentWeapon = _sword;
        _player.Attack(_currentWeapon);
    }
    
    private void OnGunButtonClicked()
    {
        _currentWeapon = _gun;
        _player.Attack(_currentWeapon);
    }
    
    private void OnGrenadeButtonClicked()
    {
        _currentWeapon = _grenade;
        _player.Attack(_currentWeapon);
    }
}
