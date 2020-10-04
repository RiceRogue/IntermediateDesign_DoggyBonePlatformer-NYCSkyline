using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Bone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dog;
    private bool boned = false;
    public bool gotBone;

    public int Score;
    public TextMeshProUGUI ScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(boned == true){

          transform.position = Vector3.MoveTowards(transform.position, dog.transform.position, Random.Range(0.04f, 0.3f));
        //new Vector3(dog.transform.position.x, dog.transform.position.y, 10);
            gotBone = true;
        }
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Dog")
        {   
            boned = true;
            GetComponent<Collider2D>().enabled = false;
            //transform.position = Vector3.MoveTowards(transform.position, collision.transform.position, 1f);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Dog")
        {   
            
            
        }
    }


   
}
