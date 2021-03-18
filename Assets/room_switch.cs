#if UNITY_EDITOR
 using UnityEditor;
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    public bool start = false;
    public bool starting = false;
    public bool gameOver =false;
    public GameObject txt;
    public bool finished = false;
    public bool finished2 = false;
    public bool lvl1Pass = false;
    public bool lvl2Pass = false;
    public bool onlvl1 = false;
    public bool onlvl2 = false;
    //public float speed = 0.02f;
    //public float jump = 3f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CharacterController>().enabled = false;
        transform.position = new Vector3(100f, -0.2f, 38.52f);
        GetComponent<CharacterController>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(0.13f, -0.2f, 34.52f);
            GetComponent<CharacterController>().enabled = true;
            GameObject.Find("ground").transform.position = new Vector3(0, -0.9f, 0);
            onlvl1 = true;
        }
        if (Input.GetKeyDown("2") && lvl1Pass)
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(-100f, -0.2f, 34.52f);
            GetComponent<CharacterController>().enabled = true;
            GameObject.Find("ground2").transform.position = new Vector3(-100, -0.9f, 0);
            onlvl1 = true;
        }
        if (Input.GetKeyDown("3") && lvl2Pass)
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(-200f, -0.2f, 34.52f);
            GetComponent<CharacterController>().enabled = true;
            GameObject.Find("ground3").transform.position = new Vector3(-200, -0.9f, 0);
            onlvl1 = true;
        }
        if (!start&& onlvl1)
        {
            GetComponent<CharacterController>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && onlvl1)
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<CharacterController>().enabled = false;
                transform.position = new Vector3(100f, -0.2f, 38.52f);
                GetComponent<CharacterController>().enabled = true;
                txt.GetComponent<UnityEngine.UI.Text>().text = "";
                start = false;
                starting = false;
                gameOver = false;
                finished = false;
                onlvl1 = false;
}
        }
        //transform.position = transform.position + new Vector3(0, 0, speed * -1);
        //GetComponent<CharacterController>().enabled = true;
        if (finished)
        {
            lvl1Pass = true;
            //zVector += new Vector3(0f, 0f, 10f);
            //reset position of ground and chickens
            //reset camera position
            //increase the speed
            //GameObject.Find("ground").transform.position = new Vector3(0, -0.9f, 0);
            //transform.position = new Vector3(0.13f, -0.2f, 33.48f)  ;
            //GameObject.Find("FPSController").Rigidbody.mass += 1;
            //float speed = GameObject.Find("ground").GetComponent<groundMove>().speed;
            //GameObject.Find("ground").GetComponent<groundMove>().speed = speed*1.2f;
            finished = false;
            start = false;
            onlvl1 = false;
            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(100f, -0.2f, 38.52f);
            GetComponent<CharacterController>().enabled = true;
            starting = false;
        }

        if (finished2)
        {
            lvl2Pass = true;
            finished2 = false;
            start = false;

            GetComponent<CharacterController>().enabled = false;
            transform.position = new Vector3(100f, -0.2f, 38.52f);
            GetComponent<CharacterController>().enabled = true;
            starting = false;
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

