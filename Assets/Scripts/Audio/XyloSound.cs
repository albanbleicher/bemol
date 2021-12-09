using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XyloSound : MonoBehaviour
{
    private AudioSource audio;

    public static XyloSound Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    private void Start() {
        audio = GetComponent<AudioSource>();
    }

    public void Play() {
        audio.Play();
    }

    public void Stop() {
        audio.Play();
    }
}