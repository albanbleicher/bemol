using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FifthCollider : MonoBehaviour
{

    IEnumerator OnTriggerEnter(Collider other) {
        SubtitlesManager.Instance.show("Cette ventilation pourrait peut-être m'aider à le déboucher ?");
        yield return new WaitForSeconds(4f);
        SubtitlesManager.Instance.hide();
    }
}
