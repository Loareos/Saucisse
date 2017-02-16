using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class shop : MonoBehaviour {

	public Canvas canvasShop;
    public Canvas canvasGame;
	public int compteur;
	public int prix1 = 30;
    public int prix2 = 500;
    public int prix3 = 500;
    public int prix4 = 500;
    public int prix5 = 500;
    public int prix6 = 500;
    public bool saucisse2 = false;
    public bool saucisse3 = false;
    public bool saucisse4 = false;
    public bool saucisse5 = false;
    public bool saucisse6 = false;
    public bool saucisse7 = false;



    // Use this for initialization
    void Start () {
        canvasGame.enabled = true;
        canvasShop.enabled = false;
        GameObject.Find("Achat1").GetComponent<Image>().color = Color.black;
        GameObject.Find("Achat2").GetComponent<Image>().color = Color.black;
        GameObject.Find("Achat3").GetComponent<Image>().color = Color.black;
        GameObject.Find("Achat4").GetComponent<Image>().color = Color.black;
        GameObject.Find("Achat5").GetComponent<Image>().color = Color.black;
        GameObject.Find("Achat6").GetComponent<Image>().color = Color.black;

    }

    // Update is called once per frame
    void Update () {
	 //return ressources;

	}

	public void Achat() {
		compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
		if (compteur >= prix1) {
			saucisse2 = true;
            GameObject.Find("Achat1").GetComponent<Image>().color = Color.white;

        }
    }
    public void Achat2()
    {
        compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        if (compteur >= prix2)
        {
            saucisse3 = true;
            GameObject.Find("Achat2").GetComponent<Image>().color = Color.white;

        }
    }
    public void Achat3()
    {
        compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        if (compteur >= prix3)
        {
            saucisse4 = true;
            GameObject.Find("Achat3").GetComponent<Image>().color = Color.white;

        }
    }
    public void Achat4()
    {
        compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        if (compteur >= prix4)
        {
            saucisse5 = true;
            GameObject.Find("Achat4").GetComponent<Image>().color = Color.white;

        }
    }
    public void Achat5()
    {
        compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        if (compteur >= prix5)
        {
            saucisse6 = true;
            GameObject.Find("Achat5").GetComponent<Image>().color = Color.white;

        }
    }
    public void Achat6()
    {
        compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        if (compteur >= prix6)
        {
            saucisse7 = true;
            GameObject.Find("Achat6").GetComponent<Image>().color = Color.white;

        }
    }

    public void openShop()
    {
            canvasShop.enabled = true;
            canvasGame.enabled = false;
        }
    public void openGame()
    {
        canvasShop.enabled = false;
        canvasGame.enabled = true;
    }
}


