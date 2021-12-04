using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerationZone : MonoBehaviour
{
    public delegate void onAerationZoneEnterAction();
    public static event onAerationZoneEnterAction onAerationZoneEnter;

    private void OnTriggerEnter(Collider other)
    {
        onAerationZoneEnter();
    }
}
