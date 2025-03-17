using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour, IExplosible
{
    public void Explode()
    {
        GameController.instance.OnPlayerDead.Invoke();
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
