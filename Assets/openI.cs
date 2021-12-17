using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openI : MonoBehaviour
{

    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled;
        }
    }
}
