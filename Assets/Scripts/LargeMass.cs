using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMass : MonoBehaviour {
    public Vector3 velocity;
    public Vector3 acceleration;
    public double mass;
    public float radius;

    public Transform velocityArrow;
    public Transform accelerationArrow;

    // Start is called before the first frame update
    void Start() {
        
    }
    
    // FixedUpdate is called once per "tick"
    void FixedUpdate() {
        // Rotate the earth (visual effect)
        transform.Rotate(new Vector3(0f, 10f, 0f) * Time.deltaTime);

        // Scale the velocity arrow to the magnitude of the velocity (plus a bit less than the radius of the world)
        velocityArrow.localScale = new Vector3(0.1f, velocity.magnitude + radius * 0.9f, 0.1f);

        // Reposition the arrow to the current position of the world.
        velocityArrow.position = transform.position + velocity;
        
        // Rotate the velocity arrow to the direction of velocity.
        // LookAt takes a world position, so we calculate the position to look at
        velocityArrow.LookAt(velocityArrow.position + velocity);
        // LookAt actually makes the forward axis point at the position, so we rotate 90 degrees
        // around the x axis to have the up axis point at the position.
        velocityArrow.Rotate(new Vector3(90, 0, 0));

        // Scale the acceleration arrow to the magnitude of the acceleration (plus a bit less than the radius of the world)
        accelerationArrow.localScale = new Vector3(0.1f, acceleration.magnitude + radius * 0.9f, 0.1f);

        // Reposition the arrow to the current position of the world.
        accelerationArrow.position = transform.position + acceleration;
        
        // Rotate the acceleration arrow to the direction of acceleration.
        // LookAt takes a world position, so we calculate the position to look at
        accelerationArrow.LookAt(accelerationArrow.position + acceleration);
        // LookAt actually makes the forward axis point at the position, so we rotate 90 degrees
        // around the x axis to have the up axis point at the position.
        accelerationArrow.Rotate(new Vector3(90, 0, 0));
    }
}
