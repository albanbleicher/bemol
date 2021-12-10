using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtitlesManager : MonoBehaviour
{
    public Text subtitles;
    
    public static SubtitlesManager Instance;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        subtitles = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hide() {
        subtitles.CrossFadeAlpha(0, 0.4f, false);
    }

    public void show(string text) {
        subtitles.CrossFadeAlpha(1, 0.4f, false);
        subtitles.text = text;
    }

}
