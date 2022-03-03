using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float runSpeed = 20;

    public Animator topTorso;
    public Animator botTorso;
    


    private float horizontal;
    private float vertical;

    private Rigidbody2D body;

    private bool isMoving = false;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovePlayer();
        RotateBody();
        
    }

    private void FixedUpdate()
    {
        body.AddForce(new Vector2(horizontal * runSpeed, vertical * runSpeed));
    }
    void MovePlayer()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 | vertical != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    void RotateBody()
    {
        Vector3 difference;
        float distance = Vector3.Distance(gameObject.transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));

        difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        difference.Normalize();

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        topTorso.transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }




}
