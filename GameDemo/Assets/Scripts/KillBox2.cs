using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox2 : MonoBehaviour
{

public static string sceneName;


void Update(){
    
    //Restart 
    Scene currentScene = SceneManager.GetActiveScene();  
    sceneName = currentScene.name;
     
 }

  void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        //Scene currentScene = SceneManager.GetActiveScene();  
        //string sceneName = currentScene.name;
        
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Death");
            SceneManager.LoadScene("LoseScene");
        }
    }
}
