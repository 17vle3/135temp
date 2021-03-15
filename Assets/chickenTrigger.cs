using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenTrigger : MonoBehaviour
{
    public bool touched = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("FPSController")) { 
        GameObject.Find("FPSController").GetComponent<room_switch>().gameOver = true;
        touched = true;
        }
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
