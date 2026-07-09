using UnityEditor;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audiosource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void PlaySE() 
    {
        audiosource.Play();
    }
}
