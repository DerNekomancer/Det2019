using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitpoints : MonoBehaviour
{

    public Hitpoints(int amount)
    {
        this.count = amount;
    }
    public Image[] hearts;
    int count = 3;
    // Start is called before the first frame update
    void Start()
    {
    
        //Debug.Log(count.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(count.ToString());
        //Debug.Log("damageTaken");
        if (count == 2)
        {
            hearts[2].color = Color.gray;
            Debug.Log("Kek");
        }
        if (count == 1)
        {
            hearts[2].color = Color.gray;
            hearts[1].color = Color.gray;
        }
        if (count == 0)
        {
            hearts[2].color = Color.gray;
            hearts[1].color = Color.gray;
            hearts[0].color = Color.gray;
        }
    }
    public void damageTaken()
    {
        //Debug.Log("Leben: " + count.ToString());
        //count--;
        //Debug.Log("Leben: " + count.ToString());
    }
}
