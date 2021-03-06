using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

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

    public void NextLevel (){
            if(KillBox2.sceneName == "TutorialLevel"){
                SceneManager.LoadScene("LevelOne");
            }

            if(KillBox2.sceneName == "LevelOne"){
                SceneManager.LoadScene("LevelTwo");
            }

            if(KillBox2.sceneName == "LevelTwo"){
                SceneManager.LoadScene("MainMenu");
            }
        // SceneManager.LoadScene("LevelOne");
        // Debug.Log("scene switch");
    }
    
    public void Tutorial (){
        SceneManager.LoadScene("TutorialLevel");
        Debug.Log("Level Two");
    }

    public void LevelOne (){
        SceneManager.LoadScene("LevelOne");
        Debug.Log("Level One");
    }

    public void LevelTwo (){
        SceneManager.LoadScene("LevelTwo");
        Debug.Log("Level Two");
    }

    public void Back (){
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Back to main menu");
    }

    public AudioMixer audioMixer;
    public void SetVolume (float volume){
        Debug.Log(volume);
        audioMixer.SetFloat("volume", volume);
    }

}
