using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
      SceneManager.LoadScene("SampleScene");
   }
}
