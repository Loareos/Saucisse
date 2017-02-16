using UnityEngine;
using System.Collections;

public class saucisse : MonoBehaviour {

    public GameObject saucisseGene;
    float axe = 0f;

	// Use this for initialization
	void Start () {
        axe = saucisseGene.transform.position.y;
        float camHalfHeight = Camera.main.orthographicSize;
        transform.position = new Vector3(Random.Range(-camHalfHeight, camHalfHeight), axe, 91);
        Destroy(gameObject, 3);
    }
	
	// Update is called once per frame
	/*void OnTriggerEnter2D (Collider2D col) {
        if (col.tag == "Finish") {
            Destroy.gameObject;
        }

        
        
	}*/
}
