using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {
    // Member variable so it can be reused instead of allocated on every update
    double gravitational_constant = 1;
    List<Vector3> accelerations;
    public Transform centerOfMass;

    // Start is called before the first frame update
    void Start() {
        accelerations = new List<Vector3>(transform.childCount);
    }

    // FixedUpdate is called once per "tick"
    void FixedUpdate() {
        accelerations.Clear();
        for (int i = 0; i < transform.childCount; ++i) {
            accelerations.Add(new Vector3(0.0f, 0.0f, 0.0f));
        }
        for (int i = 0; i < transform.childCount; ++i) {
            for (int j = 0; j < i; ++j) {
                Transform child1 = transform.GetChild(i);
                Transform child2 = transform.GetChild(j);
                Vector3 vector = child2.position - child1.position;
                double distance = vector.magnitude;
                LargeMass obj1 = (LargeMass)child1.gameObject.GetComponent(typeof(LargeMass));
                LargeMass obj2 = (LargeMass)child1.gameObject.GetComponent(typeof(LargeMass));
                double force = gravitational_constant * obj1.mass * obj2.mass / (distance * distance);
                Vector3 acc1 = ((float)(force / obj1.mass)) * (vector.normalized);
                Vector3 acc2 = ((float)(force / obj2.mass)) * (-vector.normalized);
                accelerations[i] += acc1;
                accelerations[j] += acc2;
            }
        }
        Vector3 groupVector = new Vector3(0.0f, 0.0f, 0.0f);
        for (int i = 0; i < transform.childCount; ++i) {
            Transform child = transform.GetChild(i);
            groupVector += child.position;
            LargeMass obj = (LargeMass)child.gameObject.GetComponent(typeof(LargeMass));
            obj.velocity += accelerations[i] * Time.fixedDeltaTime;
            child.position += obj.velocity * Time.fixedDeltaTime;
        }
        Vector3 COM = groupVector / transform.childCount;
        centerOfMass.position = COM;
    }
}
