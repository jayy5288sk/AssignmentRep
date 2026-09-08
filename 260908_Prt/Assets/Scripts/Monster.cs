using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamagable
{
    public GameObject getObject { get => this.gameObject; }

    public void TakeDamage(int damage)
    {
        Debug.Log($"{gameObject.name}: 데미지 {damage} 피격받음.");
    }
}
