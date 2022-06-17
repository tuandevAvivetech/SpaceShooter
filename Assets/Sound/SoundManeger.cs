using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoundManeger : MonoBehaviour
{
    public static SoundManeger Instance;

    [SerializeField] private AudioSource _musicSource, _effectSound;
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI Text;
     void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _effectSound.PlayOneShot(clip);
    }
    public void ToggleEffect()
    {
        Debug.Log("ToggleEffect");
        _effectSound.mute = !_effectSound.mute;
    }
    public void ToggleAudio()
    {
        Debug.Log("ToggleAudio");
        _musicSource.mute = !_musicSource.mute;
        if(_musicSource.mute)
            Text.text = "OFF";
    }
    public void ChangMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    
}
