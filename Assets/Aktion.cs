using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aktion : MonoBehaviour
{
    public string wert;
    public string[] keys={"a","s","d"};
    public TextMeshPro textelement;
    // Start is called before the first frame update
    void Start()
    {  
        //ToDo: setze einen Random Wert
        int random = Random.Range(0, 4);
        wert = keys[random];
        textelement.text = wert;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
