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

    public IEnumerator Unflash() {
    
        flashAnimation.Rewind("FlashInstrument");
        yield return new WaitForSeconds(0.01f);
        flashAnimation.Stop();

    }
}
