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

    private void Awake() {
        Instance = this;
        isOnZone = false;
        queriesHitTriggers = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        onAerationZoneEnter();
        isOnZone = true;
        ClickToBlowText.Instance.showText();
    }

        private void OnTriggerExit(Collider other)
    {
        isOnZone = false;
        ClickToBlowText.Instance.hideText();
    }

    void OnMouseDrag() {
        Debug.Log("mouse down");
        ShakingController.Instance.ShakeCamera(0.0f, 0.2f, .1f);
    }
}
