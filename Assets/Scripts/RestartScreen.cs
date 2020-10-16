using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RestartScreen : MonoBehaviour
{
    public Button restartButton;
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject camlock;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Dog").GetComponent<WALKING>().winning == true){
            
            canvas2.SetActive(false);
            canvas.SetActive(true);
            cam.transform.position = new Vector3(camlock.transform.position.x, camlock.transform.position.y, -10);
            
        }
        
    }

     void TaskOnClick()
    {

        SceneManager.LoadScene("GAME1");
        

    }
}
