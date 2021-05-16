using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageReact : MonoBehaviour
{
    public ReactiveTarget reactiveTarget;
    public Sprite imageInfo;
    public Image imageObj;
    void Start()
    {
        reactiveTarget.react.AddListener(ImageSelect);
    }

    public void ImageSelect()
    {
        imageObj.sprite = imageInfo;
        GameModManager.gmm.GameMod = GameMod.Info;
    }
}