using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Tumbler : MonoBehaviour
{
    [SerializeField]private bool flag;
    public bool Flag
    {
        get
        {
            return flag;
        }
        set
        {
            if (value != flag)
            {
                flag = value;
                TumblerEvent();
            }
        }
    }

    public UnityEvent OnTumblerOn;
    public UnityEvent OnTumblerOff;

    private void Start()
    {
        TumblerEvent();
    }

    public void TumblerEvent()
    {
        if (flag)
        {
            OnTumblerOn.Invoke();
        }
        else
        {
            OnTumblerOff.Invoke();
        }
    }

}
