using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tödlich : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other){
        GameObject go = other.gameObject;
        if(go.CompareTag("Player")){
            go.GetComponent<spielerbewegung>().respawn();
        }
    }
}
