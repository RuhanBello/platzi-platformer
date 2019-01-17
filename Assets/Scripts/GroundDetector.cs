using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour {
    public bool isGrounded;

    private void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider collider) {
        if (collider.gameObject.tag == "Ground") {
            isGrounded = false;
        }
    }
}
