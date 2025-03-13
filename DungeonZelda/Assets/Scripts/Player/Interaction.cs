using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    IInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Interact()
    {
        interactable?.Interact();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IInteractable target))
        {
            interactable = target;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interactable = null;
    }
}
