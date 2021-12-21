using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D : MonoBehaviour
{
    public static Item giveb;
    public Item i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="player")
        {
            if(Input.GetKey(KeyCode.R))
            {
                giveb=i;
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="player")
        {
            if(Input.GetKey(KeyCode.R))
            {
                giveb=i;
                Destroy(gameObject);
            }
        }
    }
}
