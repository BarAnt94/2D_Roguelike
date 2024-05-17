using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float MoveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 MoveInput;

    private float activeMoveSpeed;
    public float dashSpeed;

    public float dashLenght = .5f, dashCooldown = 1f;

    private float DashCounter;
    private float DashCoolCounter;

    // Start is called before the first frame update
    void Start()
    {
        activeMoveSpeed = MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput.x = Input.GetAxisRaw("Horizontal");
        MoveInput.y = Input.GetAxisRaw("Vertical");

        MoveInput.Normalize();

        rb2d.velocity = MoveInput * activeMoveSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (DashCoolCounter <= 0 && DashCounter <= 0)
            {
                activeMoveSpeed = dashSpeed;
                DashCounter = dashLenght;

            }
        }

        if (DashCounter > 0);
        {
            DashCounter -= Time.deltaTime;

            if (DashCounter <= 0)
            {
                activeMoveSpeed = MoveSpeed;
                DashCoolCounter = dashCooldown;

            }
            if (DashCoolCounter > 0)
            {
                DashCoolCounter -= Time.deltaTime;
            }
        }


    }

}   




