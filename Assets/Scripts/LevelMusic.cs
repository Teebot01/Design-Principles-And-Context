using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    public AudioSource audiosourcelevelMusic;
    public AudioClip levelMusic;
    // Start is called before the first frame update
    void Start()
    {
        audiosourcelevelMusic.clip = levelMusic;
        audiosourcelevelMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
