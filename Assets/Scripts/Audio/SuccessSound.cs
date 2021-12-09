using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSound : MonoBehaviour
{
    public AudioClip successSound;

    public static SuccessSound Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void Play() {
        AudioManager.Instance.SwapTrack(successSound);
    }
}