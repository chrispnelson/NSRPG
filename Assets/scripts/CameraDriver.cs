using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDriver : MonoBehaviour
{

	public GameObject particle;

	private float mouseVirt;
	private float mouseHorz;
	private float horzSpeed = 2.0f;
	private float virtSpeed = 2.0f;
	
	
	// Update is called once per frame
	void Update ()
	{

		mouseVirt += virtSpeed * (Input.GetAxis("Mouse X"));
		mouseHorz += horzSpeed * (Input.GetAxis("Mouse Y"));
	
		transform.rotation = Quaternion.Euler(mouseHorz, mouseVirt, 0);
	}
}
