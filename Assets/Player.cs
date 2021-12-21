using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hp=5;
    public Scrollbar sc;
    private int l=1;
    public static bool immunit=true;
    public float stop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.size = (float)hp/5;
        if(l==1)
        {
            l=0;
            StartCoroutine(Wait());
        }
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(stop);
        immunit=false;
        l=1;
    }
}
