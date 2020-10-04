using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WALKING : MonoBehaviour
{
    //public Rigidbody rb2D;
    private bool isGrounded;
    public bool winning = false;
    private int time;
    private Color color = new Color(0f, 0f, 0f, 1);
     public int Score;
     public GameObject canvas;
    public TextMeshProUGUI ScoreText;

    public Rigidbody2D rgb;

    public float speed = 1.0f;
      public Vector2 Rights = new Vector2(20, 0);
        public Vector2 Lefts = new Vector2(-20, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "0";
        rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate(){

        if(Input.GetKey(KeyCode.RightArrow)){
            rgb.AddForce(transform.right * 500.0f, ForceMode2D.Impulse);
        } if(Input.GetKey(KeyCode.LeftArrow)){
            rgb.AddForce(transform.right * -500.0f, ForceMode2D.Impulse);
        }
    }
    void LateUpdate(){
        
        if(Input.GetKey(KeyCode.RightArrow)){
            
            GetComponent<Animator>().Play("WalkRight");
        } if(Input.GetKey(KeyCode.LeftArrow)){
            
            GetComponent<Animator>().Play("WalkLeft");
        }
        
         if(Input.GetKeyDown(KeyCode.UpArrow)){
            if (time < 0){
                time = 0;
            }
            if(time == 0){ 
                rgb.AddForce(transform.up * 1000.0f, ForceMode2D.Impulse);
                GetComponent<Animator>().Play("WalkUp");
                time = 120;
                }

                
        } else if ( !Input.anyKey) {
            
             GetComponent<Animator>().Play("Idler");
                
            
        }

        if(time > 0){
            time--;
        }

        ScoreText.text = Score.ToString();
        
        
    }   
    

 private float coloConvert(float num) {
         return (num / 255.0f);
     }

void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {   
            color.r = coloConvert(Random.Range(0,255));
            color.g = coloConvert(Random.Range(0,255));
            color.b = coloConvert(Random.Range(0,255));
            collision.gameObject.GetComponent<Renderer>().material.color = color;
            
            
             
        }

        if (collision.gameObject.name == "SUN"){

             if(Score == 6){
                winning = true;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bone")
        {   
            Score++;
            
            //ScoreText.text = Score.ToString();

        }
    }
}

    