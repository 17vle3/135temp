using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedTrigger : MonoBehaviour
{
    public Rigidbody seed;
    public bool pushed = false;
    public bool onGround = false;
    void OnTriggerEnter(Collider other)
    {
        pushed = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pushed && Input.GetKeyDown("1"))
        {
            seed.useGravity = true;
        }
        if(seed.transform.position == new Vector3(-4.78f, -0.72f, -12.21f) && Input.GetKeyDown("1"))
        {
            onGround=true;
            seed.transform.position = new Vector3(-4.78f, 2.1f, -12.21f);
            seed.useGravity = false;
            pushed = false;
        }
    }
}
