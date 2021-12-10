using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToBlowText : MonoBehaviour
{
    Text text;
    public static ClickToBlowText Instance {get; private set;}
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        text = GetComponent<Text>();
    }

    void Start() {
        text.CrossFadeAlpha(0, 0f, false);  
    }

    // Update is called once per frame
    public void show()
    {
        text.CrossFadeAlpha(1, 0.5f, false);
    }

    public void hide() {
        text.CrossFadeAlpha(0, 0.2f, false);
    }
}
