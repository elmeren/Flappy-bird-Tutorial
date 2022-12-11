using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpPower;
    [SerializeField] KeyCode jumpKeyCode;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKeyCode))
        {
            rb.velocity = new Vector2(0, jumpPower);
        }

        if (rb.velocity.y < 0)
        {
            transform.Rotate(0, 0, -0.1f);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
