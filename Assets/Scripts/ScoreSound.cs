﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSound : MonoBehaviour {

    public void PlayChime()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
