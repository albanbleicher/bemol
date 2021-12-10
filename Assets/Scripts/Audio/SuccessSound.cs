using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSound : MonoBehaviour
{
    public AudioSource audio;

    public static SuccessSound Instance;

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
}