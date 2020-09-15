using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WALKING : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Transform>().Translate(new Vector3(1,0,0));
            GetComponent<Animator>().Play("WalkRight");
        } else if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Transform>().Translate(new Vector3(-1,0,0));
            GetComponent<Animator>().Play("WalkLeft");
        } else if(Input.GetKey(KeyCode.UpArrow)){
            GetComponent<Transform>().Translate(new Vector3(0,1,0));
            GetComponent<Animator>().Play("WalkUp");
        } else if(Input.GetKey(KeyCode.DownArrow)){
            GetComponent<Transform>().Translate(new Vector3(0,-1,0));
            GetComponent<Animator>().Play("WalkDown");
        } else {
            GetComponent<Animator>().Play("Idler");
        }
    }
}
