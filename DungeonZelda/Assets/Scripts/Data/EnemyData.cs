using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Data/Characters/Enemy", fileName = "newEnemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] float life;

    public float Life { get => life; set => life -= value; }

}
