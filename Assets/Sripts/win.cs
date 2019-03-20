using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{

    public GameObject winTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        winTimer.GetComponent<Timer>().setWinTime();
            winGame();

           
        
    }

    public void winGame()
    {
        SceneManager.LoadScene("Win"); // loads current scene
    }
}
