using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public bool gameStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        DontDestroyOnLoad(this);

    }


        public void ButtonPressedToStartGame()
        {
            SceneManager.LoadScene("GAME1");
            gameStarted = true;
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
