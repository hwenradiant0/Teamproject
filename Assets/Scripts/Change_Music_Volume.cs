﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Music_Volume : MonoBehaviour
{
    public Slider Volume;
    public AudioSource myMusic;

    private void Update()
    {
        myMusic.volume = Volume.value;
    }
}
