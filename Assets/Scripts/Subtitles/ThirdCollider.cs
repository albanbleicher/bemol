using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCollider : MonoBehaviour
{

    IEnumerator OnTriggerEnter(Collider other) {
        SubtitlesManager.Instance.hide();
        yield return new WaitForSeconds(1.5f);
        SubtitlesManager.Instance.show("On dirait de l'huile ...");
    }
}
