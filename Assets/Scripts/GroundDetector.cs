using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour {
    public bool isGrounded;

    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider collision) {
        if (collision.gameObject.tag == "Ground") {
            isGrounded = false;
        }
    }
}
