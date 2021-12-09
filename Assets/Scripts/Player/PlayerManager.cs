using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;
    private Animation flashAnimation;
    public void Awake() {
        if (Instance == null) {
            Instance = this;
        }
        flashAnimation = GetComponent<Animation>();
    }

    public void Flash() {
        flashAnimation.Play();
    }
}
