using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public Transform follow;

    // Update is called once per frame
    void Update() {
        transform.position = follow.position - new Vector3(0f, 0f, 30f);
    }
}
