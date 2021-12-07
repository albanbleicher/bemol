using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToBlowText : MonoBehaviour
{
    Text text;
    public static ClickToBlowText Instance  {get; private set; }

  void Awake()
    { 
      Instance = this;
      text = GetComponent<Text>();
      text.CrossFadeAlpha(0, 0f, false);
    }

  void Start() 
  {
  }

  public void showText()
  {
    text.CrossFadeAlpha(1, 0.5f, false);
  }

  public void hideText()
  {
    text.CrossFadeAlpha(0, 0.5f, false);
  }

}
