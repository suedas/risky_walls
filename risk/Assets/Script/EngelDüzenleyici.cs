﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelDüzenleyici : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EngelManager.instance.engelYerlestir(collision.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="altin")
        {
            col.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
