using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baubereich : MonoBehaviour
{   public int benoetigtesHolz;
    public int benoetigtesStein;
    public GameState gamestate;
    // Start is called before the first frame update
    void Start()
    {
        gamestate = GameState.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(benoetigtesHolz);
        Debug.Log(benoetigtesStein);
        Debug.Log(other);
        Debug.Log(gamestate);
        if(benoetigtesHolz<=gamestate.Holzanzahl && benoetigtesStein<=gamestate.Steinanzahl){
            gamestate.Holzanzahl -= benoetigtesHolz;
            gamestate.Steinanzahl -= benoetigtesStein;
            SceneManager.LoadScene("minigame 1");
        }
    }
}
