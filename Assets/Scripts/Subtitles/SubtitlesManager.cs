using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesManager : MonoBehaviour
{
    private Text subtitles;
    // Start is called before the first frame update
    void Start()
    {
        subtitles = GetComponent<Text>();
        StartCoroutine(HideFirstSubitile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator HideFirstSubitile() {
        yield return new WaitForSeconds(1f);

        subtitles.CrossFadeAlpha(0, 0.1f, false);
    }
}
