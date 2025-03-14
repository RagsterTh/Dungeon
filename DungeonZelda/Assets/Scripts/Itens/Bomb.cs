using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    [SerializeField] float timeToExplode;
    public UnityEvent OnExplode;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Explode());
    }
    IEnumerator Explode()
    {
        yield return new WaitForSeconds(timeToExplode);
        OnExplode.Invoke();
    }

}
