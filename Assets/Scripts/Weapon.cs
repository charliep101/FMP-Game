using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage = 10;
    public float firerate = 0;

    public Transform muzzle;

    [SerializeField] private Transform bullet;

    private Player player;
    float timeToFire = 0;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(firerate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
            else
            {
                if (Input.GetButtonDown("Fire1") && Time.time > timeToFire)
                {
                    timeToFire = Time.time + 1 / firerate;
                    Fire();
                }
            }
        }

        void Fire()
        {
            Vector2 muzzlePos = new Vector2(muzzle.position.x, muzzle.position.y);

            SpawnBullet();
        }

        void SpawnBullet()
        {
            if(bullet == null)
            {
                return;
            }

            Transform shot = Instantiate(bullet, muzzle.position, muzzle.rotation);
            shot.GetComponent<Bullet>().damage = damage;

            
           
        }
    }
}
