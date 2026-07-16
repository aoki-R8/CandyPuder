using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] seaudioClips;
    public AudioSource seaudiosource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlaySE() 
    {
        seaudiosource.clip = seaudioClips[0];
        seaudiosource.Play();
    }

    public AudioClip[] bgmAudioClips;
    public AudioSource bgmAudiosource;
    public void PlayBGM() 
    {
        bgmAudiosource.clip = bgmAudioClips[0];
        bgmAudiosource.Play();
        
    
    }

    public void Start()
    {
        seaudiosource = this.gameObject.AddComponent<AudioSource>();
        bgmAudiosource = this.gameObject.AddComponent<AudioSource>();
        bgmAudiosource.loop = true;
        PlayBGM();
        
    }
}
