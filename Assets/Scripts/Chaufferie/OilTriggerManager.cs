using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilTriggerManager : MonoBehaviour
{
    // public delegate void onOilEnterAction();
    // public static event onOilEnterAction onOilEnter;
    public AudioClip newTrack;
    // private Animation flashBemol;
    private bool interactionIsDone = false;

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("EnterOnCollider");
        // flashBemol = GetComponent<Animation>();

        StartCoroutine(LaunchInteraction());
        // LaunchInteraction();
        // onOilEnter();
    }

    private IEnumerator LaunchInteraction() {

        if (interactionIsDone == false) {
            interactionIsDone = true;
            RepairSound.Instance.Play();
            PlayerManager.Instance.Flash();

            yield return new WaitForSeconds(2f);
            SuccessSound.Instance.Play();
            yield return new WaitForSeconds(1.5f);
            StartCoroutine(XyloSound.Instance.Play());
            SubtitlesManager.Instance.hide();
            yield return new WaitForSeconds(1.5f);
            SubtitlesManager.Instance.show("Eh mais... je peux rejouer de mon xylo !");
            yield return new WaitForSeconds(4f);
            SubtitlesManager.Instance.hide();

            // PlayerManager.Instance.StopFadeTrack();

            // AudioManager.Instance.SwapTrack(newTrack);

            Debug.Log("interactionDone");
        }


    }
}
