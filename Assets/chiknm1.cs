using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiknm1 : MonoBehaviour
{
    public float x;
    bool once = true;
    bool moved = false;
    bool waitNextFinish = false;
    public bool finished;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool finished = GameObject.Find("FPSController").GetComponent<room_switch>().finished;
        bool start = GameObject.Find("FPSController").GetComponent<room_switch>().onlvl1;

        if (start && once)
        {

            Vector3 position = transform.position;
            int r = Random.Range(0, 3);
            if (r == 0) { x = -100f + -97.3f; }
            else if (r == 1) { x = -100f + -99.1f; }
            else if (r == 2) { x = -100f + -100.9f; }
            else { x = -102.7f; }

            transform.position = new Vector3(x, position.y, position.z);
            moved = true;
            once = false;
        }
        if (!start && moved)
        {
            //wait for next finish
            waitNextFinish = true;
        }
        if (waitNextFinish && start)
        {
            once = true;
            moved = false;
            waitNextFinish = false;
        }
    }
}
