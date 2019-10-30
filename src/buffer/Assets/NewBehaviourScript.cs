using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera cam = Camera.main;
        transform.parent = cam.transform;
        float distance = cam.nearClipPlane + 3.0f;
        transform.localPosition = new Vector3(0, 0, distance);
        transform.localRotation = new Quaternion();
        float inv=(float)Screen.width/Screen.height;
        float s = Mathf.Tan(0.5f * cam.fieldOfView * Mathf.Deg2Rad) * 2.0f * distance;
        transform.localScale = new Vector3(inv * s, s, 1);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
