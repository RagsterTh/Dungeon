using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour, IDamageable, IExplosible
{
    [SerializeField] EnemyData enemyData;
    public void Explode()
    {
        gameObject.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        enemyData.Life -= damage;
        if(enemyData.Life <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
