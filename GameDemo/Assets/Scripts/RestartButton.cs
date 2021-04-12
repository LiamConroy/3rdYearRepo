﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{

    //public static bool musicPlaying; 
    // Start is called before the first frame update
    void Start()
    {
        //musicPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        Scene currentScene = SceneManager.GetActiveScene();  
        string sceneName = currentScene.name;

        if(Input.GetKey("r")){
            Debug.Log("game restart");
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
