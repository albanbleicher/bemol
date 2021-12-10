using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthCollider : MonoBehaviour
{

    IEnumerator OnTriggerEnter(Collider other) {
        SubtitlesManager.Instance.show("Mince, j'ai l'impression que mon trombone a aussi un problème...");
        yield return new WaitForSeconds(5f);
        SubtitlesManager.Instance.hide();
    }
}
