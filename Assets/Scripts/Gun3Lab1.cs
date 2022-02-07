using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun3Lab1 : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootPlace;
    public Text gameOverText;
    public Text ammoText;
    public static bool gameOff;
    private int ammo = 5;
    public GameObject bonus;
    private Vector3 x;

    public int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            if (value < 1)
                ammo = 1;
            else if (value > 10)
                ammo = 10;
            else
                ammo = value;
        }
    }

    public void AmmoText()
    {
        ammoText.text = "Ammo: " + ammo;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bonus")
        {
            Ammo = Ammo + 5;
            Destroy(col.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            gameOverText.gameObject.SetActive(true);
            gameOff = true;
        }
    }

    public void Shoot()
    {
        for (int i = 1; (i <= 1 && ammo > 0); i++, ammo--)
        {
            GameObject bulletClone = Instantiate(bullet, shootPlace.transform.position, bullet.transform.rotation);
            bulletClone.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 150.0f, 0);
            Destroy(bulletClone, 1.0f);
        }
            if(ammo == 0)
            {
                Vector3 bonusPos = BonusPos();
                GameObject bonusClone = Instantiate(bonus, bonusPos, bonus.transform.rotation);
            }
        
    }

    private Vector3 BonusPos()
    {
        int s = Random.Range(0, 1);
        switch (s)
        {
            case 0:
                x = new Vector3(-95.7f, -48.29997f, 0);
                break;
            case 1:
                x = new Vector3(98.1f, -48.29997f, 0);
                break;
        }
        return x;
    }

    public void PlayerControl()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-50.0f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(50.0f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        if (gameOff == false)
        {
            if (ammo != 0)
            {

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Shoot();
                }
            }
        }
    }

    void Update()
    {
        PlayerControl();
        AmmoText();
        
    }
}
