using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInfo : MonoBehaviour
{
    [SerializeField] private string _boxName = "기본 상자";

    private void Start()
    {
        Debug.Log($"Start: {_boxName}가 벨트에 올라왔습니다.");
    }

    private void OnDestroy()
    {
        Debug.Log($"OnDestroy: {_boxName}가 벨트 끝으로 내려갔습니다.");
    }
}
