using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public string itemName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("22: " + itemName);  
        if (other.CompareTag("Player"))
        {
            Debug.Log("Eingesammelt: " + itemName);  
        }
    }
}