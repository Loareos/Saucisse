using UnityEngine;
using System.Collections;

public class PrimalSaucisse : MonoBehaviour
{

    public GameObject saucissePrefab;
    int multip;
    public int compteur;
    public static int nbDeSaucisse;

    public GameObject saucissePrefab2;
    public bool saucisse2;
    int prix;
    bool isSell = false;

    public GameObject saucissePrefab3;
    public bool saucisse3;
    int prix2;
    bool isSell2 = false;

    public GameObject saucissePrefab4;
    public bool saucisse4;
    int prix3;
    bool isSell3 = false;

    public GameObject saucissePrefab5;
    public bool saucisse5;
    int prix4;
    bool isSell4 = false;

    public GameObject saucissePrefab6;
    public bool saucisse6;
    int prix5;
    bool isSell5 = false;

    public GameObject saucissePrefab7;
    public bool saucisse7;
    int prix6;
    bool isSell6 = false;




    void Start()
    {
        nbDeSaucisse = PlayerPrefs.GetInt("SaucisseNombreSave");
    }


	void Update(){
        multip = GameObject.Find("Multiplicateur").GetComponent<Multiplicateur>().multiplicateur;


        saucisse2 = GameObject.Find ("ShopAdd").GetComponent<shop> ().saucisse2;
        prix = GameObject.Find("ShopAdd").GetComponent<shop>().prix1;

        saucisse3 = GameObject.Find("ShopAdd").GetComponent<shop>().saucisse3;
        prix2 = GameObject.Find("ShopAdd").GetComponent<shop>().prix2;

        saucisse4 = GameObject.Find("ShopAdd").GetComponent<shop>().saucisse4;
        prix3 = GameObject.Find("ShopAdd").GetComponent<shop>().prix3;

        saucisse5 = GameObject.Find("ShopAdd").GetComponent<shop>().saucisse5;
        prix4 = GameObject.Find("ShopAdd").GetComponent<shop>().prix4;

        saucisse6 = GameObject.Find("ShopAdd").GetComponent<shop>().saucisse6;
        prix5 = GameObject.Find("ShopAdd").GetComponent<shop>().prix5;

        saucisse7 = GameObject.Find("ShopAdd").GetComponent<shop>().saucisse7;
        prix6 = GameObject.Find("ShopAdd").GetComponent<shop>().prix6;

    }

    public void GenerateSaucisse()
    {
        
        GameObject.Instantiate(saucissePrefab);
        compteur += 1 * multip;

		if (saucisse2){
			GameObject.Instantiate (saucissePrefab2);
			compteur += 2 * multip;
		}
        if (saucisse3)
        {
            GameObject.Instantiate(saucissePrefab3);
            compteur += 3 * multip;
        }

        if (saucisse4)
        {
            GameObject.Instantiate(saucissePrefab4);
            compteur += 5 * multip;
        }

        if (saucisse5)
        {
            GameObject.Instantiate(saucissePrefab5);
            compteur += 7 * multip;
        }

        if (saucisse6)
        {
            GameObject.Instantiate(saucissePrefab6);
            compteur += 9 * multip;
        }

        if (saucisse7)
        {
            GameObject.Instantiate(saucissePrefab7);
            compteur += 15 * multip;
        }


    }

    public void taxation()
    {
        if (!isSell && compteur >= prix)
        {
            compteur -= prix;
            isSell = true;
        }
    }

    public void taxation2()
    {
        if (!isSell2 && compteur >= prix2)
        {
            compteur -= prix2;
            isSell2 = true;
        }
    }

    public void taxation3()
    {
        if (!isSell3 && compteur >= prix3)
        {
            compteur -= prix3;
            isSell3 = true;
        }
    }
    public void taxation4()
    {
        if (!isSell4 && compteur >= prix4)
        {
            compteur -= prix4;
            isSell4 = true;
        }
    }
    public void taxation5()
    {
        if (!isSell5 && compteur >= prix5)
        {
            compteur -= prix5;
            isSell5 = true;
        }
    }
    public void taxation6()
    {
        if (!isSell6 && compteur >= prix6)
        {
            compteur -= prix6;
            isSell6 = true;
        }
    }
}