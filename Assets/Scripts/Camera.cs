using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform follow;
    public float zoomDistance = 30f;

    // Update is called once per frame
    void Update() {
        // Scroll mouse to zoom camera in or out
        zoomDistance -= Input.mouseScrollDelta.y;

        // Position camera based on center of mass
        transform.position = follow.position - Vector3.forward * zoomDistance;
    }
}
