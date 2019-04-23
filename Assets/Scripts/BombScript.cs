using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public Transform EnemyCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
            //Destroy(EnemyCube);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
