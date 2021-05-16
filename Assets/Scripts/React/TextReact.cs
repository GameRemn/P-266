using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextReact : MonoBehaviour
{
    public ReactiveTarget reactiveTarget;
    [TextArea()]
    public string textInfo;
    public Text text;
    void Start()
    {
        reactiveTarget.react.AddListener(TextPrint);
    }

    public void TextPrint()
    {
        text.text = textInfo;
        GameModManager.gmm.GameMod = GameMod.Info;
    }
}
