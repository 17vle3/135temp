using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishTrigger2 : MonoBehaviour
{
    public bool touched = false;
    void OnTriggerEnter(Collider other)
    {
        GameObject.Find("FPSController").GetComponent<room_switch>().finished2 = true;
        //GameObject.Find("1X1").GetComponent<chickenMove>().finished = true;
        touched = true;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
