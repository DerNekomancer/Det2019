
using System.Collections.Generic;
using UnityEngine;
using System;


public class PlayerMove : MonoBehaviour
{
    public GameObject Missile;
    public float moveSpeed = 300f;
    public float turnSpeed = 5000f;
    public Hitpoints hp;
    

    // Star is called before the first frame update
    void Start()
    {

     
    /* transform.position = new Vector3(304,6,220);
     print(transform.position.x);
     UnityEngine.Debug.Log("Kek");*/
    }

    // Update is called once per frame
    void Update()
    {   //move tasten
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(5f * moveSpeed * -Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5f * moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 5f * moveSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, 5f * moveSpeed * -Time.deltaTime, 0f);
        }

        //Rotate tasten
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
        }
        //Geschoss
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            Vector3 shootPoint = transform.position;
           /*GameObject missile1 = */ Instantiate(Missile, shootPoint, Quaternion.identity);

        }
        
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("CollisionEnter");
            hp.damageTaken();
        
    }
}
