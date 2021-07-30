using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource soundtracks;
    public AudioSource[] soundtracksArray;
 
    void Update()
    {
        if (!soundtracks.isPlaying)
        {
            PlayAudioTracksRandom();
        }
    }

    void PlayAudioTracksRandom()
    {
        if (!soundtracks.isPlaying)
        {
            soundtracks = soundtracksArray[Random.Range(0, soundtracksArray.Length)];
            soundtracks.Play();
            soundtracks.PlayDelayed(44100);
        }
    }
}
