using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        if(other.gameObject.tag=="player")
        {
            if(Player.immunit!=true)
            {
                other.gameObject.GetComponent<Player>().hp-=1;
                Player.immunit=true;
            }
        }
    }
}
