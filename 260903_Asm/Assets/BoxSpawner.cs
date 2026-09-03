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
        CountTime();
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
        BeltMover move = newBox.AddComponent<BeltMover>();
        move.SetMove(_beltSpeed);
        
        Destroy(newBox, _lifeSeconds);
        
        _nextIndex++;
        
        if (_nextIndex >= _boxPrefab.Count)
        {
            _nextIndex = 0;
        }
    }

    public void CountTime()
    {
        _elapsed += Time.deltaTime;
        if (_elapsed >= _spawnInterval)
        {
            SpawnOne();
            _elapsed = 0;
        }
    }
}

// 2. 1초로 설정했을 때는 1/4 지점까지 오고 Destroy, 20초로 설정하면 belt의 5배 길이만큼 이동하고 사라진다.
// 3. 상자가 생기는 자리는 그대로였고 함께 넘기는 형태가 BoxSpawner가 연결된 Spawner를 기준으로 자리를 잡게 된다.
