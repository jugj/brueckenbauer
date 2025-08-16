using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState Instance {get; private set;}
    public int Holzanzahl;

    private void Awake(){
        if(Instance != null || Instance != this){
            Destroy(Instance);
        }

        Instance = this;

        DontDestroyOnLoad(Instance);
    }

}
