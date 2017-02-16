using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuiteGame : MonoBehaviour {

    void Start()
    {
     //PlayerPrefs.SetInt("SaucisseNombreSave", nmbrdesaucisse);
    }


    public void Quit()
    {
        Application.Quit();
    }

}
