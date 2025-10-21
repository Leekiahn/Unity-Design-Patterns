using System;
using UnityEngine;
using UnityEngine.UI;

public class DIController : MonoBehaviour
{
    [SerializeField] private Button _swordButton;
    [SerializeField] private Button _gunButton;
    [SerializeField] private Button _grenadeButton;
    
    private IWeapon _currentWeapon; 
    private Sword _sword; 
    private Gun _gun; 
    private Grenade _grenade;
    
    [SerializeField] private PlayerController _player;

    private void Awake()
    {
        if (_swordButton == null) { Debug.LogError("Sword 버튼이 할당되지 않았습니다."); return; }
        if (_gunButton == null) { Debug.LogError("Gun 버튼이 할당되지 않았습니다."); return; }
        if (_grenadeButton == null) { Debug.LogError("Grenade 버튼이 할당되지 않았습니다."); return; }

        if (!_swordButton.gameObject.TryGetComponent(out _sword)) { Debug.LogError("Sword 컴포넌트를 찾을 수 없습니다."); return; }
        if (!_gunButton.gameObject.TryGetComponent(out _gun)) { Debug.LogError("Gun 컴포넌트를 찾을 수 없습니다."); return; }
        if (!_grenadeButton.gameObject.TryGetComponent(out _grenade)) { Debug.LogError("Grenade 컴포넌트를 찾을 수 없습니다."); return;}

        _swordButton.onClick.AddListener(OnSwordButtonClicked);
        _gunButton.onClick.AddListener(OnGunButtonClicked);
        _grenadeButton.onClick.AddListener(OnGrenadeButtonClicked);
        
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

    private void OnDestroy()
    {
        _swordButton.onClick.RemoveListener(OnSwordButtonClicked);
        _gunButton.onClick.RemoveListener(OnGunButtonClicked);
        _grenadeButton.onClick.RemoveListener(OnGrenadeButtonClicked);
    }
}
