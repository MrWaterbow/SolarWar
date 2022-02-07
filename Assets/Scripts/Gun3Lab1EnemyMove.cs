using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun3Lab1EnemyMove : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(EnemyMoveDown());
    }

    public IEnumerator EnemyMoveDown()
    {
        for (float i = 0; i <= 100 && Gun3Lab1.gameOff == false; i = i + 10)
        {
            yield return new WaitForSeconds(5.0f);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -50.0f, 0);
            
            yield return new WaitForSeconds(0.25f);
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "bullet")
        {
            StopAllCoroutines();
            Debug.Log("Bullet col");
        }
    }
}
