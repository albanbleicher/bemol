using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // public AudioClip defaultMusic;
    
    private AudioSource track01, track02;
    private bool isPlayingTrack01;

    public static AudioManager Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    private void Start() {
        track01 = gameObject.AddComponent<AudioSource>();
        track02 = gameObject.AddComponent<AudioSource>();
        // track01.loop = true;
        // track02.loop = true;
        track01.volume = 0.2f;
        track02.volume = 0.4f;
    
        isPlayingTrack01 = true;
       
        // SwapTrack(defaultMusic);
    }

    public void SwapTrack(AudioClip newClip) {
        StopAllCoroutines();

        StartCoroutine(FadeTrack(newClip));
        isPlayingTrack01 = !isPlayingTrack01;
    }

    private IEnumerator FadeTrack(AudioClip newClip) {

        float timeToFade = 0.3f;
        float timeElapsed = 0f;

        if (isPlayingTrack01 == true) {
            track02.clip = newClip;
            track02.Play();

            while (timeElapsed < timeToFade) {
                track02.volume = Mathf.Lerp(0, 0.2f, timeElapsed / timeToFade);
                track01.volume = Mathf.Lerp(0.2f, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            track01.Stop();
        } else {
            track01.clip = newClip;
            track01.Play();
            while (timeElapsed < timeToFade) {
                track02.volume = Mathf.Lerp(0.2f, 0, timeElapsed / timeToFade);
                track01.volume = Mathf.Lerp(0, 0.2f, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
                yield return null;
            }
            track02.Stop();
        }
    }

    public void StopFadeTrack() {
        float timeToFade = 0.3f;
        float timeElapsed = 0f;

        if (isPlayingTrack01 == true) {
            while (timeElapsed < timeToFade) {
                track01.volume = Mathf.Lerp(0.2f, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
        } else {
            while (timeElapsed < timeToFade) {
                track02.volume = Mathf.Lerp(0.2f, 0, timeElapsed / timeToFade);
                timeElapsed += Time.deltaTime;
            }
        }
    }  
}

