using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;
    public bool isMute = false;

    private AudioSource audioSrc;
    [SerializeField] AudioClip[] sounds;
   
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySound(string sound, float volume)
    {
        if (!isMute)
        {
            switch (sound)
            {
                case "Vagabond":
                    audioSrc.PlayOneShot(sounds[0], volume);
                    break;
                case "Nightingale":
                    audioSrc.PlayOneShot(sounds[1], volume);
                    break;
                case "xx":
                    audioSrc.PlayOneShot(sounds[2], volume);
                    break;
                default:
                    Debug.Log("there is no sound with that given name :" + sound);
                    break;
            }
        }
    }

}
