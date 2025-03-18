using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Characters/Player", fileName = "newPlayer")]
public class PlayerData : ScriptableObject
{
    [SerializeField] float life;
    public float GetLife()
    {
        return life;
    }
}
