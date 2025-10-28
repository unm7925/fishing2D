
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    float speed = 5.0f;


    Vector2 moveDirection;
    Rigidbody2D rb2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool hasControl = (moveDirection != Vector2.zero);

        if (hasControl)
        {
            rb2D.MovePosition(rb2D.position + moveDirection * speed * Time.fixedDeltaTime);
        }
        /*
        MoveX = Input.GetAxis("Horizontal");
        MoveY = Input.GetAxis("Vertical");

        MoveXY = new Vector2(MoveX, MoveY);
        rb2D.AddForce(MoveXY);
        */
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        if (input != null)
        {
            if (input.x > 0.0f)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f); // 오른쪽을 보도록 회전
            }
            else if (input.x < 0.0f)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f); // 왼쪽을 보도록 회전
            }
            moveDirection = new Vector2(input.x, input.y);
        }
    }
}
