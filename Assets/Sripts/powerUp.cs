using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public GameObject player;
    public GameObject speedEagle;
    public float speed;
    public float jumpSpeed;
    bool isTrigger = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isTrigger)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                speedEagle.GetComponent<SpriteRenderer>().enabled = true;
                player.GetComponent<PlayerMovement>().speedUp(speed);
                player.GetComponent<CharacterController2D>().jumpUp(jumpSpeed);
                Destroy(gameObject); // this destroys the bullet

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
