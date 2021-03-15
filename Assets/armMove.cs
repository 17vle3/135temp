using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armMove : MonoBehaviour
{
    public Collider egg;

    void OnTriggerEnter(Collider egg)
    {
        //if arm collides with egg attach to arm
        egg.transform.position = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        if (Input.GetKey("f")){
            transform.rotation = Quaternion.Euler(rotation.x + 0, rotation.y - .1f, rotation.z);
            //rotation y - .1
        }
        if (Input.GetKey("h"))
        {
            transform.rotation = Quaternion.Euler(rotation.x + 0, rotation.y + .1f, rotation.z);
            //rotation y +.1
        }
        if (Input.GetKey("t"))
        {
            transform.rotation = Quaternion.Euler(rotation.x + .1f, rotation.y,  rotation.z);
            //rotation x +.1
        }
        if (Input.GetKey("g")){
            transform.rotation = Quaternion.Euler(rotation.x - .1f, rotation.y ,  rotation.z);
            //rotation x -.1
        }


    }
}
