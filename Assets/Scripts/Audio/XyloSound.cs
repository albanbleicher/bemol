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

    public IEnumerator Play() {
        
        float timeToFade = 0.3f;
        float timeElapsed = 0f;

        audio.Play();

        while (timeElapsed < timeToFade) {
            audio.volume = Mathf.Lerp(0, 0.1f, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    public void Stop() {
        audio.Stop();
    }
}