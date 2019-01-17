using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerController : MonoBehaviour {
    public float speed = 10;
    public float jumpForce;

    private Rigidbody myRigidbody;

    // Use this for initialization
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");

        myRigidbody.velocity = new Vector3(horizontal * speed, myRigidbody.velocity.y, 0);

        if (horizontal > 0)
            transform.rotation = Quaternion.Euler(0, 90, 0);

        if (horizontal < 0)
            transform.rotation = Quaternion.Euler(0, -90, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
