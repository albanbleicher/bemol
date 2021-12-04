using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ParametersCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public Material characterMaterial;
    public Color emissionIntensity;
	private Animation flashAnim;

    void Start() {
        characterMaterial = GetComponent<Renderer>().material;
        flashAnim = GetComponent<Animation>();
        emissionIntensity = characterMaterial.GetColor("_EmissionColor");
        HandleColorSmoke.onSmokeEnter += onSmokeEnter;
    }

    IEnumerator FlashCharacter() {
        characterMaterial.DOColor(emissionIntensity * 4, "_EmissionColor", 0.2f);
        yield return new WaitForSeconds(0.2f);
        characterMaterial.DOColor(Color.red, "_EmissionColor", 0.8f);
    }

    void onSmokeEnter() {
        Debug.Log("WESH");
        flashAnim.Play();
        // characterMaterial.DOColor(Color.red, "_EmissionColor", 10f);
        // StartCoroutine(FlashCharacter());
    }
}
