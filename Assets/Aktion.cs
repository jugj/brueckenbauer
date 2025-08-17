using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aktion : MonoBehaviour
{
    public string wert;
    public TextMeshProUGUI textelement;
    // Start is called before the first frame update
    void Start()
    {  
        //ToDo: setze einen Random Wert
        wert = "i";
        textelement.text = wert;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
