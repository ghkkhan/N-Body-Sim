using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMass : MonoBehaviour {
    public Vector3 velocity;
    public double mass;
    public double radius;

    public Transform velocityArrow;

    // Start is called before the first frame update
    void Start() {
        
    }

    // FixedUpdate is called once per "tick"
    void FixedUpdate() {
        transform.Rotate(new Vector3(0f, 10f, 0f) * Time.deltaTime);
        velocityArrow.localScale = new Vector3(0.1f, velocity.magnitude, 0.1f);

        float zAngle = Mathf.Rad2Deg * Mathf.Atan2(velocity.y, velocity.x) + 90;

        Debug.Log(velocity + "" + zAngle);

        velocityArrow.rotation = Quaternion.Euler(0.0f, 0.0f, zAngle);

        velocityArrow.position = transform.position + velocity;
    }
}
