using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerationZone : MonoBehaviour
{
    // public delegate void onAerationZoneEnterAction();
    // public static event onAerationZoneEnterAction onAerationZoneEnter;
    public static AerationZone Instance  {get; private set; }
    public static bool queriesHitTriggers;
    public AudioClip newTrack;
    public AudioClip repairSound;
    public bool isOnZone;
    public bool isOnMouseDown;
    public bool FlashOnBlowCanPlay = true;
    public float timer = 0f;

    // public AudioClip brokenMusicBox2;

    private void Awake() {
        Instance = this;
        isOnZone = false;
        queriesHitTriggers = true;
    }

    private void Update () {
        
        if (isOnMouseDown == true) {
            timer += Time.deltaTime;
        } else {
            timer = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // onAerationZoneEnter();
        isOnZone = true;
        if (FlashOnBlowCanPlay == true) {
            ClickToBlowText.Instance.show();
        }
    }

        private void OnTriggerExit(Collider other)
    {
        isOnZone = false;
        if (FlashOnBlowCanPlay == true) {
            ClickToBlowText.Instance.hide();
        }
    }

    void OnMouseDown() {
        Debug.Log("mouseDown");
        if (FlashOnBlowCanPlay == true && isOnZone == true) {
            Debug.Log("LaunchXyloAndFlash");
            XyloSound.Instance.Stop();
            PlayerManager.Instance.Flash();
            AudioManager.Instance.SwapTrack(repairSound);
        }
        isOnMouseDown = true;
    }

    void OnMouseDrag() {
        if (FlashOnBlowCanPlay == true) {

            // ShakingController.Instance.ShakeCamera(0.0f, 0.2f, .1f);
            if (timer >= 2) {
                ClickToBlowText.Instance.hide();
                StartCoroutine(PlayOnSuccess());

                // ClickToBlowText.Instance.hideText();
                // SuccessSound.Instance.Play();
                // yield return new WaitForSeconds(1f);
                // AudioManager.Instance.SwapTrack(brokenMusicBox2);
            }
        } else {
            // ShakingController.Instance.ShakeCamera(0.0f, 0f, 0f);
            // yield return null;
        }

    }

    void OnMouseUp() {
        isOnMouseDown = false;
        Debug.Log(timer);
        if (timer >= 2) {
            // yield return new WaitForSeconds(1.5f);
            // StartCoroutine(TrompetteSound.Instance.Play());
            // AudioManager.Instance.SwapTrack(newTrack);
            // ParametersCharacter.Instance.RewindFlashAfterSuccess();
            // BemolManager.Instance.Flash();
            FlashOnBlowCanPlay = false;
        } else if (FlashOnBlowCanPlay == true) {
            RepairSound.Instance.Stop();
            // Stop Repair Sound
            // StartCoroutine(ParametersCharacter.Instance.stopFlashOnBlow());
            StartCoroutine(PlayerManager.Instance.Unflash());
        }
    }

    IEnumerator PlayOnSuccess() {
        SuccessSound.Instance.Play();
        yield return new WaitForSeconds(1.5f);
        AudioManager.Instance.SwapTrack(newTrack);
        // yield return new WaitForSeconds(1.5f);
        // SubtitlesManager.Instance.show("Ah, quel plaisir de le réentendre.");
        
    }
}
