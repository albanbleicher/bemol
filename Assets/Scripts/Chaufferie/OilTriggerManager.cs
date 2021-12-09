using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilTriggerManager : MonoBehaviour
{
    public delegate void onOilEnterAction();
    public static event onOilEnterAction onOilEnter;
    public AudioClip newTrack;
    // private Animation flashBemol;
    private bool interactionIsDone = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EnterOnCollider");
        // flashBemol = GetComponent<Animation>();

        StartCoroutine(LaunchInteraction());
        // LaunchInteraction();
        // onOilEnter();
    }

    private IEnumerator LaunchInteraction() {

        if (interactionIsDone == false) {
            RepairSound.Instance.Play();
            PlayerManager.Instance.Flash();

            yield return new WaitForSeconds(2f);
            SuccessSound.Instance.Play();
            XyloSound.Instance.Play();

            // PlayerManager.Instance.StopFadeTrack();

            // AudioManager.Instance.SwapTrack(newTrack);

            interactionIsDone = true;
            Debug.Log("interactionDone");
        }


    }
}
