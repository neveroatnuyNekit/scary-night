using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
       
    void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        float moveby = x * speed;
        float y = Input.GetAxisRaw("Vertical");
        float movebyy = y * speed;
        rb.velocity = new Vector2(moveby, movebyy);
    }
    

}
