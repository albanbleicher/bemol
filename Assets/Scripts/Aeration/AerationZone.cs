using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerationZone : MonoBehaviour
{
    public delegate void onAerationZoneEnterAction();
    public static event onAerationZoneEnterAction onAerationZoneEnter;
    public static AerationZone Instance  {get; private set; }
    public static bool queriesHitTriggers;
    public bool isOnZone;
    public bool isOnMouseDown;
    public bool FlashOnBlowCanPlay = true;
    public float timer = 0f;

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
        onAerationZoneEnter();
        isOnZone = true;
        if (FlashOnBlowCanPlay == true) {
            ClickToBlowText.Instance.showText();
        }
    }

        private void OnTriggerExit(Collider other)
    {
        isOnZone = false;
        if (FlashOnBlowCanPlay == true) {
            ClickToBlowText.Instance.hideText();
        }
    }

    void OnMouseDown() {
        if (FlashOnBlowCanPlay == true) {
            ParametersCharacter.Instance.playFlashOnBlow();
        }
        isOnMouseDown = true;
    }

    void OnMouseDrag() {
        if (FlashOnBlowCanPlay == true) {
            ShakingController.Instance.ShakeCamera(0.0f, 0.2f, .1f);
            if (timer >= 3) {
                ClickToBlowText.Instance.hideText();
            }
        } else {
            ShakingController.Instance.ShakeCamera(0.0f, 0f, 0f);
        }

    }

    IEnumerator OnMouseUp() {
        isOnMouseDown = false;
        if (timer >= 3) {
            yield return new WaitForSeconds(0.5f);
            ParametersCharacter.Instance.RewindFlashAfterSuccess();
            FlashOnBlowCanPlay = false;
        } else if (FlashOnBlowCanPlay == true) {
            Debug.Log("StopFlash");
            StartCoroutine(ParametersCharacter.Instance.stopFlashOnBlow());
        }
    }
}
