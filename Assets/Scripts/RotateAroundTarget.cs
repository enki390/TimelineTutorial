using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour {
    public Transform Target;
    public float Distance = 5.0f;
    public float AnglePerSec = 90.0f;
    float currentAngle = 0.0f;

	// Update is called once per frame
	void Update () {
        Vector3 direction = (transform.position - Target.position).normalized;
        float angle = AnglePerSec * Time.deltaTime;
        currentAngle = (currentAngle + angle) % 360.0f;
        if (currentAngle < 0)
            currentAngle += 360.0f;

        direction = Quaternion.AngleAxis(currentAngle, Target.up) * Target.right;
        transform.position = Target.position + (direction * Distance);
	}
}
