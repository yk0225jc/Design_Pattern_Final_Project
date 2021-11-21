using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private AudioSource[] allAudioSources;

    public void BGM1ButtonClick1()
    {
        Debug.Log("BGM1 playing");
        BGMManager.Instance.PlaySound("Vagabond", 1f);
    }
    public void BGM1ButtonClick2()
    {
        Debug.Log("BGM2 playing");
        BGMManager.Instance.PlaySound("Nightingale", 1f);
    }
    public void Mute()
    {
        Debug.Log("All BGM been muted");
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }
}
