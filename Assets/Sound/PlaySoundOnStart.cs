using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private void Start()
    {
        SoundManeger.Instance.PlaySound(_clip);
    }
}
