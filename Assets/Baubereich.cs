using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baubereich : MonoBehaviour
{   public int benötigtesHolz;
    public int benötigtesStein;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collision2D other){
        if(benötigtesHolz<=gesammeltesHolz && benötigtesStein<=gesammeltesHolz){
            gesammeltesHolz -= benötigtesHolz
            SceneManager.LoadScene("Minigame1")
        }
    }
}
