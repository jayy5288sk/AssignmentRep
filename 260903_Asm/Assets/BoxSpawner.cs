using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _boxPrefab;
    [SerializeField] private Transform _boxRoot;
    [SerializeField] private float _spawnInterval;
    [SerializeField] private float _beltSpeed;
    [SerializeField] private float _lifeSeconds;

    private float _elapsed;
    private int _nextIndex;
    
    
}
