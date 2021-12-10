using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCollider : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider other) {
        SubtitlesManager.Instance.hide();
        yield return new WaitForSeconds(1.5f);
        SubtitlesManager.Instance.show("On dirait que mon bras est grippé... Mon pauvre xylophone, on ne va pas rejouer ensemble pour un moment je pense ...");
    }
}
