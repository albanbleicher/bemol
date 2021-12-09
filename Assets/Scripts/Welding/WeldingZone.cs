using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldingZone : MonoBehaviour
{

    public AudioClip brokenMusicBox3;
    public bool hasAlreadyRepair = false;

    // private void OnTriggerEnter() {
    //     triggerWelding();
    // } 

    // IEnumerator triggerWelding() {
    //     if (hasAlreadyRepair == false) {
    //         BemolManager.Instance.Flash();
    //         RepairSound.Instance.Play();
    //         yield return new WaitForSeconds(2f);
    //         SuccessSound.Instance.Play();
    //         yield return new WaitForSeconds(1f);
    //         AudioManager.Instance.SwapTrack(brokenMusicBox3);   
    //     }
    // }
}
