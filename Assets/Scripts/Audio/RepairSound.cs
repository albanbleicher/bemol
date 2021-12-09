using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairSound : MonoBehaviour
{
    public AudioClip repairSound;

    public static RepairSound Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    public void Play() {
        AudioManager.Instance.SwapTrack(repairSound);
    }
}
