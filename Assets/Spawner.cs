using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Aktion;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(spawneAktion), 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawneAktion(){
        GameObject neueAktion = Instantiate(Aktion, gameObject.transform.position, gameObject.transform.rotation);
    }
}
