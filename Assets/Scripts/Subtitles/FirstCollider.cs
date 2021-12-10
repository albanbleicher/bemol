using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCollider : MonoBehaviour
{

    IEnumerator OnTriggerEnter(Collider other) {
        SubtitlesManager.Instance.hide();
        yield return new WaitForSeconds(1.5f);
        SubtitlesManager.Instance.show("Mais qu'es-ce qu'il m'est arrivé ? Mon système ne fonctionne plus normalement.");
    }

    void OnTriggerExit(Collider other) {
        // Debug.Log("trigger exit");
        // SubtitlesManager.Instance.subtitles.text = "Mais qu'es-ce qu'il m'est arrivé ? Mon système ne fonctionne plus normalement.";
    }
}
