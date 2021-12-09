using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilInteractionManager : MonoBehaviour
{
    public delegate void onOilEnterAction();
    public static event onOilEnterAction onOilEnter;
    public AudioClip newTrack;
    private Animation flashBemol;
    private bool interactionIsDone = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enteroncOLLIDER");
        flashBemol = GetComponent<Animation>();

        StartCoroutine(LaunchInteraction());
        onOilEnter();
    }

    private IEnumerator LaunchInteraction() {

        if (interactionIsDone == false) {
            RepairSound.Instance.Play();
            flashBemol.Play();

            yield return new WaitForSeconds(1.9f);

            SuccessSound.Instance.Play();

            yield return new WaitForSeconds(1f);

            AudioManager.Instance.SwapTrack(newTrack);

            interactionIsDone = true;
            Debug.Log("interactionDone");
        }


    }
}