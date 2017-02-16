using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Multiplicateur : MonoBehaviour {

    public float prog = 1f;
    int compteur;
    public float max = 100f;
    public float speed = 1f;
    public int multiplicateur = 1;
    float value;
    public Slider multi;
    public GameObject barreMulti;


    // Use this for initialization
    void Start () {
        barreMulti.GetComponent<Image>().color = Color.green;
    }
	
	// Update is called once per frame
	void Update () {

        if (prog > 0f) {
            prog -= Time.deltaTime * speed;
        }

        if (prog < 25f)
        {
            multiplicateur = 1;
            barreMulti.GetComponent<Image>().color = Color.green;

        }
        if (prog >= 25f && prog < 50f)
        {
            multiplicateur = 2;
            barreMulti.GetComponent<Image>().color = Color.yellow;

        }
        if (prog >= 50f && prog <90f)
        {
            multiplicateur = 3;
            barreMulti.GetComponent<Image>().color = Color.red;

        }
        if (prog >= 90f && prog < 100f)
        {
            multiplicateur = 5;
            barreMulti.GetComponent<Image>().color = Color.cyan;

        }
        if (prog >= max)
        {
            prog = 100f;
        }
        //      multiplicator.GetComponent<Scrollbar>().size += prog * 001f;
        multi.value = prog;


    }

    public void barre()
    {
        multi.value = prog;
    }

    public void plusUn()
    {
        prog++;
    }
}
