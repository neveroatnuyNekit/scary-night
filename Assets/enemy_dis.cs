using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dis : MonoBehaviour
{
    public float speed;
    public float GD;
    public float SD;
    public GameObject b;
    public Transform player;
    private bool ll=true;
    public float _speedRotate = 5f;
    public int rotationOffset = -90;
    private float rotZ;
    public float stop;
    private int inr=stayinrpl.radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inr=stayinrpl.radius;
        if(inr==1)
        {
            Vector3 difference = player.position - transform.position;
            rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis (rotZ + rotationOffset, Vector3.forward);
            transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * _speedRotate);
            if (Vector2.Distance(transform.position,player.position)>SD)
            {
                transform.position=Vector2.MoveTowards(transform.position,player.position,speed*Time.deltaTime);
            }
            else if(Vector2.Distance(transform.position,player.position)<SD&&(Vector2.Distance(transform.position,player.position)>GD))
            {
                transform.position=this.transform.position;
            }
            else if(Vector2.Distance(transform.position,player.position)<SD)
            {
                transform.position=Vector2.MoveTowards(transform.position,player.position,-speed*Time.deltaTime);
            }
            if(ll)
            {
                if(inr==1)
                {
                    Instantiate(b,transform.position, transform.rotation);
                    ll=false;
                    StartCoroutine(Wait());
                }
            }
        }
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(stop);
        ll=true;
    }
}
