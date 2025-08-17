using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState Instance {get; private set;}
    public int Holzanzahl = 0;

    private void Awake(){
        Debug.Log("init gamestate");
        if(Instance != null || Instance != this){
            Destroy(Instance);
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }

}
