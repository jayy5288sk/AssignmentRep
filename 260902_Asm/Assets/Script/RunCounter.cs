using UnityEngine;

public class RunCounter : MonoBehaviour  
{  
    private float _elapsed;

    private void Awake()  
    {  
        KeepAlive();  
    }

    private void Update()  
    {  
        Accumulate();  
        ReadLogKey();  
    }

    private void KeepAlive()  
    {  
        DontDestroyOnLoad(gameObject);  
        Debug.Log("RunCounter: 유지 대상으로 등록했습니다.");  
    }

    private void Accumulate()  
    {  
        _elapsed += Time.deltaTime;  
    }

    private void ReadLogKey()  
    {  
        if (Input.GetKeyDown(KeyCode.C))  
        {  
            Debug.Log($"RunCounter: 흐른 시간은 {_elapsed}초입니다.");  
        }  
    }  
}