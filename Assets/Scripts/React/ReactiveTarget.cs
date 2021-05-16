using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {
	public KeyCode kay;
	public UnityEvent react;
	public void ReactToHit()
	{
		if (react!=null)
			react.Invoke();
	}
}
