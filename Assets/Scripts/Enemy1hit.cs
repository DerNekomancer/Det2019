using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1hit : MonoBehaviour
{
    public Transform Player;
    // public Transform Bombs;
    int moveSpeed = 2;
    int maxDist = 50;
    int minDist = 0;
    int hits = 1;

    private void OnCollisionEnter(Collision collision)
    {
        //ContactPoint contact = collision.contacts[0];
        if (collision.gameObject.tag == "Bomb" || collision.gameObject.tag == "Player")
        {
            Debug.Log("green enemy got hit");
            //transform.position = new Vector3(290, 2.5f, 200);
            hits--;
            if (hits <= 0)
            {
                Destroy(gameObject);
                //Destroy(EnemyCube);
            }
        }
    }


    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);
        //transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        transform.Translate(0f, 0f, 5f * moveSpeed * Time.deltaTime);



        if (Vector3.Distance(transform.position, Player.position) <= 5)
        {
            //transform.position = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }

        /*Debug.Log(Vector3.Distance(transform.position, Bombs.position));
        if((Vector3.Distance(transform.position, Bombs.position) <= 5))
        {
            
            Destroy(gameObject);
        } */
    }
}
