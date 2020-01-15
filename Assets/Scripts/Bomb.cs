using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject explosionEffect;
    public int explosionValue;
    public LayerMask layermask;

    private void Start()
    {
        StartCoroutine(Explode(Vector3.forward));
        StartCoroutine(Explode(Vector3.right));
        StartCoroutine(Explode(Vector3.back));
        StartCoroutine(Explode(Vector3.left));
    }

    IEnumerator Explode(Vector3 direction)
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < explosionValue; i++)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), direction, out hit, i, layermask);

            if (!hit.collider)
            {
                GameObject go = Instantiate(explosionEffect, transform.position+ i*direction, Quaternion.identity);
                Destroy(gameObject);
                Destroy(go,0.5f);
            }
            else
            {
                
            }
        }
        
       
    }

  
}
