using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spielerbewegung : MonoBehaviour
{
    public float Geschwindigkeit=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey("up")){
        transform.Translate(Vector2.up * Time.deltaTime * Geschwindigkeit);}

        if(Input.GetKey("left")){
        transform.Translate(Vector2.left * Time.deltaTime * Geschwindigkeit);}

        if(Input.GetKey("right")){
        transform.Translate(Vector2.right * Time.deltaTime * Geschwindigkeit);
        }
        if(Input.GetKey("shift + left")){
        transform.Translate(Vector2.left * Time.deltaTime * 10);
        }
        if(Input.GetKey("shift + right")){
        transform.Translate(Vector2.right * Time.deltaTime * 10);
        }
        
    }
}
