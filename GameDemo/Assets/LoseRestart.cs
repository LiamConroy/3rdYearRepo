using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseRestart : MonoBehaviour
{
    int prevScene;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    
    void Update()
    {

        if(Input.GetKey("r")){
            Debug.Log("game restart");
            SceneManager.LoadScene(Bullet.sceneName);
        }
    }
}
