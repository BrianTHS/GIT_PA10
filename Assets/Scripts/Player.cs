using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float Jumpforce = 0.1f;
    Rigidbody rb;
    private Animation thisAnimation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector3.up* Jumpforce,ForceMode.Impulse);
            thisAnimation.Play();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
