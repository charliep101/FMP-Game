using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public float maxHealth = 100;
    public float health = 100;

    public float regen = 0;
    public float regenRate = 1;

    public bool isDead = false;

    Animator animator;

    

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        animator = GetComponent<Animator>();
        StartCoroutine(HpRegen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health < 0 && !isDead)
        {
            isDead = true;
        }
        if(gameObject.tag == "Player")
        {

        }
        else
        {
            animator.Play("Death");
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    IEnumerator HpRegen()
    {
        while (true)
        {
            yield return new WaitForSeconds(regenRate);
            if (health < maxHealth)
            {
                health += regen;
            }
        }
    }

}
