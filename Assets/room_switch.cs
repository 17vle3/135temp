#if UNITY_EDITOR
 using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    public bool start = false;
    bool starting = false;
    public bool gameOver =false;
    public GameObject txt;
    public bool finished = false;
    public GameObject ground;
    Vector3 zVector = new Vector3(0f, 0f, 0f);
    //public float speed = 0.02f;
    //public float jump = 3f;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<CharacterController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
        {
            GetComponent<CharacterController>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //GetComponent<CharacterController>().enabled = true;
            starting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space)&&starting)
        {
            GetComponent<CharacterController>().enabled = true;
            start = true;
        }
        
        if (gameOver)
        {
            start = false;
            txt.GetComponent<UnityEngine.UI.Text>().text = "Game Over";
            GameObject.Find("ground").GetComponent<groundMove>().speed = 0;
        }
        //transform.position = transform.position + new Vector3(0, 0, speed * -1);
        //GetComponent<CharacterController>().enabled = true;
        if (finished)
        {
            zVector += new Vector3(0f, 0f, 10f);
            //reset position of ground and chickens
            //reset camera position
            //increase the speed
            ground.transform.position = new Vector3(0, -0.9f, 0);
            transform.position = new Vector3(0.13f, -0.2f, 33.48f) + zVector ;
            //GameObject.Find("FPSController").Rigidbody.mass += 1;
            float speed = GameObject.Find("ground").GetComponent<groundMove>().speed;
            GameObject.Find("ground").GetComponent<groundMove>().speed = speed*1.2f;
            finished = false;
            start = false;
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(0.13f, -0.2f, 34.52f);
            GetComponent<CharacterController>().enabled = true;
        }
                

        //if (transform.position.y== -0.2f && Input.GetKeyDown(KeyCode.UpArrow)) { 
        //    transform.position = transform.position + new Vector3(0, jump, 0);
        //}
        if (Input.GetKeyDown("escape"))
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                        Application.Quit();
            #endif
        }

    }
}

