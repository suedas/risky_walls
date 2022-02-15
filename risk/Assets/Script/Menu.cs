using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
    
{
    [SerializeField]
    public GameObject ButtonPanel;
    bool ayarlarPaneliAcikMi;
    // Start is called before the first frame update
    void Start()
    {
        ayarlarPaneliAcikMi = false;
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    public void playButton()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }
    public void AyarlaButton()
    {
        if (!ayarlarPaneliAcikMi)
        {
            ButtonPanel.SetActive(true);
        }
       else
        {
            ButtonPanel.SetActive(false); //panel kapanmıyor

        }


    }
    public void restartButton()
    {
        SceneManager.LoadScene("OyunSahnesi");
    }

    public void sesButton()
    { 

    }
}
