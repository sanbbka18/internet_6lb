using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 5000);
        }
    }
}
