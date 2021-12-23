using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float vHorizontal = Input.GetAxis("Horizontal") * speed;
        float vVertical = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector3(vHorizontal, 0, vVertical);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
