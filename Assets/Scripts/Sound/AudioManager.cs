using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager instance;

    public SoundEffects[] music, sfx;
    public AudioSource musicSource, sfxSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }

    }

    private void Start()
    {
       // Music();
    }

    public void Music(string name)
    {
        SoundEffects song = Array.Find(music, x=> x.SongName == name);
        if (song != null)
        {
            musicSource.clip = song.SongSound;
            musicSource.Play();
        }

        else
        {
            Debug.Log("not found");
        }
    }

    public void SFX(string name)
    {
        SoundEffects song = Array.Find(sfx, x => x.SongName == name);
        if (song != null)
        {
            sfxSource.PlayOneShot(song.SongSound);
        }

        else
        {
            Debug.Log("not found");
        }
    }
}


// https://www.youtube.com/watch?v=rdX7nhH6jdM
