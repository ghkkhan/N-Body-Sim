using UnityEngine;

public class EarthCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        LargeMass otherLargeMass = collision.gameObject.GetComponent<LargeMass>();
        LargeMass thisLargeMass = this.gameObject.GetComponent<LargeMass>();

        // Vector3 otherVelocity = ;
        // Debug.Log(otherVelocity);
        Vector3 temp = otherLargeMass.velocity;
        otherLargeMass.velocity = thisLargeMass.velocity * (float)( thisLargeMass.mass / otherLargeMass.mass);
        thisLargeMass.velocity = temp * (float)(otherLargeMass.mass / thisLargeMass.mass);
        
        
        
        Debug.Log(thisLargeMass.velocity);

        // Debug.Log(thisLargeMass.velocity);
    }
}
