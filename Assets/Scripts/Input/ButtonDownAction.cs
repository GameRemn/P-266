using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonDownAction : MonoBehaviour
{
    public KeyCode kay;
    
    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true;
    }
    
    public UnityEvent unityEvent;
    private void Update()
    {
        if (Input.GetKeyDown(kay))
            unityEvent.Invoke();
    }
}
