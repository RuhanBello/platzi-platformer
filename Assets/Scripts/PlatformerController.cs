using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerController : MonoBehaviour {
    public float speed = 10;
    public float jumpForce;

    public GroundDetector groundDetector;

    private Rigidbody myRigidbody;
    private Animator animator;

    // Use this for initialization
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (groundDetector.isGrounded)
            myRigidbody.velocity = new Vector3(horizontal * speed, myRigidbody.velocity.y, 0);

        GetComponentInChildren<Animator>().SetFloat("Speed", Mathf.Abs(horizontal));

        if (horizontal > 0)
            transform.rotation = Quaternion.Euler(0, 90, 0);
        
        if (horizontal < 0)
            transform.rotation = Quaternion.Euler(0, -90, 0);

        if (groundDetector.isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            myRigidbody.AddForce(Vector3.up * jumpForce);
            GetComponentInChildren<Animator>().SetTrigger("Jump");
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "MetalBall") {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "Enemy") {
            SceneManager.LoadScene(0);
        }
    }
}
