using UnityEngine;

public class SBAgent : MonoBehaviour
{
	public Vector3 velocity = Vector3.zero;
	public float maxSteer = 1;
	public float maxSpeed = 1;
	Vector3 desired;
	Vector3 steer;
}
