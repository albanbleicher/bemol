using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour
{
	private Animation anim;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        anim = GetComponent<Animation>();

        while (true) {
            yield return new WaitForSeconds(Random.Range(2,10));
            anim.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
