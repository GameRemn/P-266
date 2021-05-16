using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {
	public KeyCode kay;

	public float rayRange;

	public Camera _camera;

	void OnEnable() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void OnGUI() {
		int size = 12;
		float posX = _camera.pixelWidth/2 - size/4;
		float posY = _camera.pixelHeight/2 - size/2;
		GUI.Label(new Rect(posX, posY, size, size), "*");
	}

	void Update() {
		if (Input.GetKeyDown(kay)) {
			Vector3 point = new Vector3(_camera.pixelWidth/2, _camera.pixelHeight/2, 0);
			Ray ray = _camera.ScreenPointToRay(point);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, rayRange)) {
				GameObject hitObject = hit.transform.gameObject;
				ReactiveTarget[] targets = hitObject.GetComponents<ReactiveTarget>();
				foreach (var target in targets)
				{
					if (target.kay == kay)
					{
						target.ReactToHit();
					}
					else
					{
					}
				}
			}
		}
	}
}