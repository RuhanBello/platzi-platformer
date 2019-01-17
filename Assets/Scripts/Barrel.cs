using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {
    public float horizontalForce;
    public float verticalForce;

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(new Vector3(horizontalForce, verticalForce, 0));
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Wall") {
            if (transform.position.x > collision.collider.transform.position.x) {
                myRigidbody.AddForce(new Vector3(horizontalForce, verticalForce, 0));
            } else {
                myRigidbody.AddForce(new Vector3(-horizontalForce, verticalForce, 0));
            }
        }
    }
}
