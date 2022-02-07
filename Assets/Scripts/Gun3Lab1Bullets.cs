using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun3Lab1Bullets : MonoBehaviour
{
    public GameObject bonus; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject.GetComponent<Gun3Lab1EnemyMove>());        //.enabled = false;
            col.gameObject.tag = "Untagged";
            Destroy(col.gameObject.GetComponent<CircleCollider2D>());
            Destroy(col.gameObject, 0.3f);
            Destroy(gameObject);
            int s = Random.Range(0, 3);
            if (s == 0)
            {
                GameObject bonusClone = Instantiate(bonus, col.gameObject.transform.position, col.gameObject.transform.rotation);
                bonusClone.AddComponent<Rigidbody2D>();
                bonusClone.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, -5.0f, 0f);
            }
            
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
