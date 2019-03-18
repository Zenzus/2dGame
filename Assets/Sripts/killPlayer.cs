using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
     
        {
            if (other.gameObject.CompareTag("Player"))
            {   


                player.GetComponent<PlayerMovement>().RestartGame();
               // Destroy(other.gameObject); // this destroys the bullet

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
