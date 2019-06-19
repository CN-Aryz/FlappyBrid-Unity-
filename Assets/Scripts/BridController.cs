using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridController : MonoBehaviour
{
    public float upForce = 200f;

    private bool isDead;

    private Rigidbody2D rb2d;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;

        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));

                animator.SetTrigger("Flap");

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        animator.SetTrigger("isDead");
        GameController.instance.BridDied();
    }
}
