using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {
    public float Distance = 5.0f;
    public float AnglePerSec = 90.0f;

	// Update is called once per frame
	void Update () {
        Transform parent = transform.parent;
        Vector3 direction = transform.localPosition.normalized;
        float angle = AnglePerSec * Time.deltaTime;
        direction = (Quaternion.AngleAxis(angle, Vector3.up) * direction) * Distance;
        transform.localPosition = direction;
	}
}
