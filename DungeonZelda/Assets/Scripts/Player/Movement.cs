using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] Transform direction;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Vector2 inputDirections;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = inputDirections * speed;

    }
    public void Move(InputAction.CallbackContext value)
    {
            inputDirections = value.ReadValue<Vector2>();


            if (inputDirections.x == 0 && inputDirections.y == 0)
                return;

            float angle = Mathf.Atan2(inputDirections.y, inputDirections.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);

            direction.rotation = targetRotation;

    }
}
