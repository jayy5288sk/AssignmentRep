using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControll : MonoBehaviour
{
    private int _damage;
    private float _speed;

    private void OnTriggerEnter(Collider other)
    {
        // 플레이어인 경우 데미지 추가 
        if (other.CompareTag("Player"))
        {
            // TODO : 데미지 추가
            //Debug.Log("player shots.");
        }

        // 벽인 경우엔 파괴
        Destroy(gameObject);
    }

    // Spawn 기준 제한시간 이후 파괴 예약.

    // if 어딘가에 부딪혔을 때
    // 플레이어인 경우 데미지 발생.
    // 벽인 경우에는 파괴

    private void Update()
    {
        MoveForward();
    }

    // 앞으로의 운동
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    // 터렛으로부터 데이터를 전달받아 총알의 속도, 파괴 시간을 입력받도록 만들자. 
    public void SetData(int damage, float speed, float destroyDelay)
    {
        _damage = damage;
        _speed = speed;

        Destroy(gameObject, destroyDelay);
    }
}
