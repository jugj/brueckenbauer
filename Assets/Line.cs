using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Line : MonoBehaviour
{
    public string aktuellerWert = "p";
    public int richtige = 0;
    public string nextLevel;
    GameObject otherGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(aktuellerWert)){
            Debug.Log("hi");
            richtige +=1;
            Destroy(otherGameObject);
        }
        if(richtige>=5){
            SceneManager.LoadScene(nextLevel);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        aktuellerWert = other.gameObject.GetComponent<Aktion>().wert;
        otherGameObject = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other){
        aktuellerWert = "#";
    }

}
