using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankZone : MonoBehaviour
{
   
   public bool isOnZone = false;
   public AudioClip cleanMusic;

   private void OnTriggerEnter() {
       isOnZone = true;
   }

   private void OnTriggerExit() {
       isOnZone = false;
   }

   private void OnMouseDrag() {
       if (isOnZone == true) {
           // If on rotate la manivelle
            // RepairSound.Instance.Play();
            // BemolManager.Instance.FLash; Maybe have to create other animation
            // If la rotation est de 360degrés * 2
                // SuccessSound.Instance.Play();
                // yield return WaitForSeconds(1f);
                // AudioManager.Instance.SwapTrack(cleanMusic);
       }
   }
}
