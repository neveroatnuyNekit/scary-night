using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Blis : MonoBehaviour
{
    public float speed;
    public Transform player;
    private int inr=Inple.radiusq;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inr=Inple.radiusq;
        if(inr==1)
        {
            transform.position=Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime);
        }
    }
}
