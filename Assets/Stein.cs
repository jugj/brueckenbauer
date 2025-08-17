using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stein : MonoBehaviour
{   
    public string itemName;
    private GameState gamestate;

    // Start is called before the first frame update
    void Start()
    {
        this.gamestate = GameState.Instance;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("22: " + gamestate);  
        if (other.CompareTag("Player"))
        {
            Debug.Log("Eingesammelt: " + itemName);  
        }

        gamestate.Steinanzahl += 1;
        Debug.Log("Steinanzahl: " + gamestate.Steinanzahl);
        Destroy(this.gameObject);

    }
      
}
