using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public GameObject camlock;
    public GameObject sprite;
    public bool start = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   
        //if(Input.GetKey(KeyCode.Space)){

            //start = true;
        //}
        
        if (start == true){
        camlock.transform.position = new Vector3(sprite.transform.position.x, sprite.transform.position.y, -10);
        cam.transform.position = new Vector3(camlock.transform.position.x, camlock.transform.position.y, -10);
        }

        if(GameObject.Find("Dog").GetComponent<WALKING>().winning == true){
            

            start = false;
        }
    }
}
