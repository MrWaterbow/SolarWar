using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun3Lab1GameOverPlace : MonoBehaviour
{
    public GameObject player;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(player.GetComponent<Rigidbody2D>());
            gameOverText.gameObject.SetActive(true);
            Gun3Lab1.gameOff = true;

        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
