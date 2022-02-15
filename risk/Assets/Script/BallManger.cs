using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// /// efect gözükmeme problemi???
/// </summary>
public class BallManger : MonoBehaviour
{
    float speed = 3.2f;
    public bool sagYon = true;
    private Vector3 stageDimensions;
    float topyarıcap = 0.42f;
    [SerializeField]
    Text PuanText;
    int puan;
    [SerializeField]
    Text ScorePuan;
    [SerializeField]
    Text HıghScore;

    [SerializeField]
    public GameObject sonucPaneli;
    private void Awake()
    {

    }
    void Start()
    {
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        //Debug.Log(stageDimensions);
        PuanText.text = puan.ToString();


        HıghScore.text = PlayerPrefs.GetInt("HıghScore", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sagYon = !sagYon;
            FindObjectOfType<OyunSesleri>().yönSes();
        }


        if (transform.position.x >= stageDimensions.x - topyarıcap)
        {
            FindObjectOfType<OyunSesleri>().topSes();
            sagYon = false;

        }
        else if (transform.position.x <= -stageDimensions.x + topyarıcap)
        {
            FindObjectOfType<OyunSesleri>().topSes();
            sagYon = true;
        }
        if (sagYon)
        {
            
            transform.position = new Vector2(transform.position.x + Time.deltaTime * speed, transform.position.y);
        }
        else if (!sagYon)
        {
            
            transform.position = new Vector2(transform.position.x - Time.deltaTime * speed, transform.position.y);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "altin") ////////altının coliderı kaldıyor gibi altını aldıktan sonra takılıyor. 
        {
            //ses yok
            Destroy(collision.gameObject);
            //collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            FindObjectOfType<OyunSesleri>().altinSes();
            puan++;
            PuanText.text = puan.ToString();
            PlayerPrefs.SetInt("HıghScore", puan);

        }
        else if (collision.gameObject.tag == "engel")
        {
            FindObjectOfType<OyunSesleri>().engelSes();
            Handheld.Vibrate();
            sonucPaneli.SetActive(true);
            Destroy(gameObject);
            ScorePuan.text = puan.ToString();
            EngelManager.instance.speed = 0;
         


        }
    }
    public void Restart()
    {
       ///////// ???????????????????
    }
    
}
