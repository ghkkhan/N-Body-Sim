using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMass : MonoBehaviour {
    public Vector3 velocity;
    public double mass;

    // Start is called before the first frame update
    void Start() {
        
    }

    // FixedUpdate is called once per "tick"
    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 50f, 0f) * Time.deltaTime);
    }
}
