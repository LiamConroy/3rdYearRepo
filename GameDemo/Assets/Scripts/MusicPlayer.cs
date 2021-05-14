using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    
    [SerializeField]
    private AudioSource music;
    public static MusicPlayer myMusicPlayer;

    void Awake() {
        if(myMusicPlayer == null) {
            myMusicPlayer = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(myMusicPlayer != this) {
            Destroy(gameObject);
        }
    }

    void Update() {
        
    }

}
