using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {
    // Member variable so it can be reused instead of allocated on every update
    List<Vector3> new_positions;

    // Start is called before the first frame update
    void Start() {
        new_positions = new List<Vector3>(transform.childCount);
    }

    // FixedUpdate is called once per "tick"
    void FixedUpdate() {
        new_positions.Clear();
        foreach (Transform child in transform) {
            // var position = child.position;
            // new_positions.Add(new Vector3(position.x, position.y, position.z));
            new_positions.Add(child.position);
        }
    }
}
