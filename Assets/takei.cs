using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takei : MonoBehaviour
{
    public static Item give;
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
            give=i;
            Destroy(gameObject);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="player")
        {
            give=i;
            Destroy(gameObject);
        }
    }

}
