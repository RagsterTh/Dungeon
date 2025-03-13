using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] Transform direction;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Bounds spriteRenderer;
    Vector2 inputDirections;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>().bounds;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = inputDirections * speed;
    }
    public void Move(InputAction.CallbackContext value)
    {
        inputDirections = value.ReadValue<Vector2>();
        //direction.position = new Vector2(bounds.min.x -0.5f, bounds.center.y);//Funcionou para a esquerda

    }
}
