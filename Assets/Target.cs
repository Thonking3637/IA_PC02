using UnityEngine;

public class Target : SBAgent
{
	void Update()
	{
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.Scale(new Vector3(1, 1, 0));
		transform.position = mousePosition;
	}
}