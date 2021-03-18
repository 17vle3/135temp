using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken3Move : MonoBehaviour
{
    public float x;
    public float x2;
    bool once = true;
    bool moved = false;
    bool waitNextFinish = false;
    public bool finished;
    public GameObject second;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool finished = GameObject.Find("FPSController").GetComponent<room_switch>().finished;
        bool start = GameObject.Find("FPSController").GetComponent<room_switch>().start;

        if (start && once)
        {

            Vector3 position = transform.position;
            Vector3 position2 = second.transform.position;
            int r = Random.Range(0, 5);
            if (r == 0) { x = -2.7f; x2 = -0.9f; }
            else if (r == 1) { x = -0.9f; x2 = .9f; }
            else if (r == 2) { x = .9f; x2 = 2.7f; }
            else if (r== 3){ x = -2.7f; x2 = .9f; }
            else if (r == 4) { x = -0.9f; x2 = 2.7f; }
            else  { x = -2.7f; x2 = 2.7f; }


            transform.position = new Vector3(x, position.y, position.z);
            second.transform.position = new Vector3(x2, position2.y, position2.z);
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
