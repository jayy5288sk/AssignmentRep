using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StimpackBuff : MonoBehaviour
{
    private PlayerMovement _playerMove;
    private float _speedBonus;
    private float _buffTime;
    private float _currentRemainTime;
    private bool _isActivated = false;
    private bool _isBuffFinish => _currentRemainTime >= _buffTime;

    private void Update()
    {
        UpdateTime();
        OffBuff();
    }

    public void ApplyBuff(PlayerMovement move, float speedBonus, float buffTime)
    {
        _playerMove = move;
        _speedBonus = speedBonus;
        _buffTime = buffTime;
        _currentRemainTime = 0f;

        _playerMove.AddPlayerSpeed(speedBonus);
        _isActivated = true;
    }
    private void UpdateTime()
    {
        if (!_isActivated)
            return;

        _currentRemainTime += Time.deltaTime;
    }

    private void OffBuff()
    {
        if(_isBuffFinish)
        {
            _playerMove.RemovePlayerSpdBuff(_speedBonus);
            Destroy(this);
        }
    }
}
