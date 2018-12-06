// Credit to damien_oconnell from http://forum.unity3d.com/threads/39513-Click-drag-camera-movement
// for using the mouse displacement for calculating the amount of camera movement and panning code.

using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{

	void Update() {
		float xAxisValue = Input.GetAxis("Horizontal"); 
    	float zAxisValue = Input.GetAxis("Vertical");
	     if(Camera.current != null)
	     {
	         Camera.current.transform.Translate(new Vector3(0, 0.0f, zAxisValue/8));
	         transform.Rotate(Vector3.up, Time.deltaTime*xAxisValue*50, Space.World);
	     }
	}
	

}