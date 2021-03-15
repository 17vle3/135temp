using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMove : MonoBehaviour
{
    public float speed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool started = GameObject.Find("FPSController").GetComponent<room_switch>().start;
        if (started && transform.position.z < 100000) { 
            transform.position = transform.position + new Vector3(0, 0, speed);
        }
    }
}
