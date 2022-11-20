using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gfit : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Santa"))
        {
            //점수 추가 스크립트
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Santa")
        {
            //점수 추가 스크립트
            Destroy(gameObject);
        }
    }
}
