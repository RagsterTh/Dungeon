using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IDamageable target))
        {
            target.TakeDamage(damage);
        }
    }
    public void AttackEnd()
    {
        gameObject.SetActive(false);
    }
}
