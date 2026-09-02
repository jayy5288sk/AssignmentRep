using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    /*private void Start()
    {
        /*SceneChanger sceneChanger = FindObjectOfType<SceneChanger>();
        if (sceneChanger != null && sceneChanger != this)
        {
            // Destroy
        }#1#
        
        DontDestroyOnLoad(gameObject);
    }*/
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("GameScene");
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //SceneManager.LoadScene("TitleMenu");
            SceneManager.LoadScene(2);
        }

        /*if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(4, LoadSceneMode.Additive);
        }*/
    }
}
