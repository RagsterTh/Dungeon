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
    Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>().bounds;
        lastPosition = direction.position;
    }
    private void Update()
    {
        Vector3 face = direction.position - lastPosition;
        if (face.magnitude > 0.01f)
        {


            float angle = Mathf.Atan2(face.y, face.x) * Mathf.Rad2Deg;

            Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);

            direction.rotation = targetRotation;


            lastPosition = direction.position;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = inputDirections * speed;

    }
    public void Move(InputAction.CallbackContext value)
    {
        inputDirections = value.ReadValue<Vector2>();


    }
}
