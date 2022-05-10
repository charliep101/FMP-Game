using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public int damage = 10;
    public int speed = 50;

    public int timer = 1;

    public int score = 0;

    public GameObject hitFX;

    

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, timer);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
       
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
           
        }

        if (col.gameObject.tag == "AEnemy")
        {
            Destroy(this.gameObject);

        }


    }


}
