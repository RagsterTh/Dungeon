using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float explosionDuration;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeEnds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ExplodeEnds()
    {
        yield return new WaitForSeconds(explosionDuration);
        transform.parent.gameObject.SetActive(false);
    }
}
