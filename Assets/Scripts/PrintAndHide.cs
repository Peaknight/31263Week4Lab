using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;
    int i = 3;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        int a = Random.Range(200, 251);

        Debug.Log(gameObject.name +":"+ i);

        if(i == 100 && GameObject.FindGameObjectWithTag("Red"))
        {
            gameObject.SetActive(false);
        }
        
        if (i == a && GameObject.FindGameObjectWithTag("Blue"))
        {
            rend = GetComponent<Renderer>();
            rend.enabled = false;
        } 
        



    }
}
