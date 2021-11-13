using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void Setvolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
    
}
