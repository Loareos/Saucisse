using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Compteur : MonoBehaviour {

    int compteur;
	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    void Update() {
		compteur = GameObject.Find("saucisseGenerator").GetComponent<PrimalSaucisse>().compteur;
        Text compte = GetComponent<Text>();
        compte.text = "Nb de saucisse :" + compteur.ToString();
    }
}
