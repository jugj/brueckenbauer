using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public string aktuellerWert = "p";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(aktuellerWert)){
            Debug.Log("hi");
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        aktuellerWert = other.gameObject.GetComponent<Aktion>().wert;
    }

    void OnTriggerExit2D(Collider2D other){
        aktuellerWert = "p";
    }

}
