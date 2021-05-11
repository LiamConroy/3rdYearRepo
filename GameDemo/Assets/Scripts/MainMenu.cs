using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    void Start(){
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }
    public void PlayGame() {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

    public void QuitGame (){
        Debug.Log("GameQuit");
        Application.Quit();
    }

    public void LevelSelect (){
        SceneManager.LoadScene("LevelSelect");
    }

    public void NextLevel (){
        SceneManager.LoadScene("LevelTwo");
        Debug.Log("scene switch");
    }

    public void LevelOne (){
        SceneManager.LoadScene("LevelOne");
        Debug.Log("Level One");
    }

    public void LevelTwo (){
        SceneManager.LoadScene("LevelTwo");
        Debug.Log("Level Two");
    }

    public void Tutorial (){
        SceneManager.LoadScene("TutorialLevel");
        Debug.Log("Level Two");
    }

    public void Back (){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Back to main menu");
    }

}
