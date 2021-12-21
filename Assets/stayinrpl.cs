using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayinrpl : MonoBehaviour
{
    public static int radius=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        //Debug.Log(radius);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Finish")
        {
            radius=1;
        }
    }void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Finish")
        {
            radius=1;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Finish")
        {
            radius=0;
        }
    }
}
