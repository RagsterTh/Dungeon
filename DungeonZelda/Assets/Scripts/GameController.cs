using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public UnityEvent OnPlayerDead;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static T GetData<T>() where T : ScriptableObject
    {
        switch (typeof(T))
        {
            /*
            case Type t when t == typeof(MeuScriptableExemplo):
                return objetoExemplo1 as T;

            case Type t when t == typeof(OutroScriptableObjeto):
                return objetoExemplo2 as T;
            */
            default:
                Debug.LogWarning("Tipo de objeto não encontrado.");
                return null;
        }
    }

}
