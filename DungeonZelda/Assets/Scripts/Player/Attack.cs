using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    [SerializeField] float cooldown;
    bool isInCooldown;
    public UnityEvent OnAttack;
    // Start is called before the first frame update
    void Start()
    {
        OnAttack.AddListener(delegate
        {
            StartCoroutine(Cooldown());
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AttackActive(InputAction.CallbackContext value)
    {
        if (!value.phase.Equals(InputActionPhase.Performed))
            return;
        if (isInCooldown)
            return;

        OnAttack.Invoke();
    }
    IEnumerator Cooldown()
    {
        isInCooldown = true;
        yield return new WaitForSeconds(cooldown);
        isInCooldown = false;
    }
}
