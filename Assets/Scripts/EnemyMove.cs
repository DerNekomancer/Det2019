using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyMove : MonoBehaviour
{

    public Transform Player;
    int moveSpeed = 2;
    int maxDist = 50;
    int minDist = 0;




    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= minDist && Vector3.Distance(transform.position, Player.position) <= maxDist)
        {

            //transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            transform.Translate(0f, 0f, 5f * moveSpeed * Time.deltaTime);


            
            if (Vector3.Distance(transform.position, Player.position) <= 5)
            {
               transform.position = new Vector3(0, 0, 0);
               
            }
        }
    }
}

