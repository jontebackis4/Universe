using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
	public GameObject centerObject;
	[Tooltip("Degrees per second")]
	public float speed = 20;
	public float distanceFromCenter = 10;

	// Start is called before the first frame update
	void Start()
	{
		Vector3 initialPosition = centerObject.transform.position;
		initialPosition.x = initialPosition.x + distanceFromCenter;
		transform.position = initialPosition;
	}

	// Update is called once per frame
	void Update()
	{
		transform.RotateAround(centerObject.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
