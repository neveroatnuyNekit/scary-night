using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up/3);
    }
    void OnTriggerEnter2D(Collider2D coll)
	{
        if(!coll.isTrigger) // чтобы пуля не реагировала на триггер
		{
            if(coll.gameObject.tag != "Finish")
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
	{
        if(!coll.isTrigger) // чтобы пуля не реагировала на триггер
		{
            if(coll.gameObject.tag != "Finish")
            {
                Destroy(gameObject);
            }
        }
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
