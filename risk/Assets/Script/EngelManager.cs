using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelManager : MonoBehaviour
{

    public static EngelManager instance;
 
    public float speed = 3f;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void engelYerlestir(GameObject obje)
    {


        if (obje.transform.GetSiblingIndex() == 0)
        {
            obje.transform.position = new Vector2(obje.transform.position.x, transform.GetChild(11).gameObject.transform.position.y + Random.Range(2.08f, 3f));

        }
        else
        {
            int i = obje.transform.GetSiblingIndex();
            obje.transform.position = new Vector2(obje.transform.position.x, transform.GetChild(i - 1).gameObject.transform.position.y + Random.Range(2.08f, 2.43f));

        }



    }

    void Update()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.transform.position = new Vector2(transform.GetChild(i).gameObject.transform.position.x, transform.GetChild(i).gameObject.transform.position.y - Time.deltaTime * speed);

        }


    }
  
}
