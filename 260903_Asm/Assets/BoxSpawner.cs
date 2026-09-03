using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _boxPrefab = new();
    [SerializeField] private Transform _boxRoot;
    [SerializeField] private float _spawnInterval;
    [SerializeField] private float _beltSpeed;
    [SerializeField] private float _lifeSeconds;

    private float _elapsed;
    private int _nextIndex;

    private void Update()
    {
        ReadSpawnKey();
    }

    private void ReadSpawnKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnOne();
        }
    }

    private void SpawnOne()
    {
        GameObject targetBox = _boxPrefab[_nextIndex];
        GameObject newBox = Instantiate(targetBox, transform.position, Quaternion.identity, _boxRoot);
        
        _nextIndex++;
        
        if (_nextIndex >= _boxPrefab.Count)
        {
            _nextIndex = 0;
        }
    }
}
