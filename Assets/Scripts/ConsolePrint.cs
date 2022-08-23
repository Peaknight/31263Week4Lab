using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        redObj.name = "RedPrefab";
        blueObj.name = "BluePrefab";
    
        
    }

    // Update is called once per frame
    void Update()
    {
       int i = 3;
        i++;
        Debug.Log(redObj.name +":"+ i);
        Debug.Log(blueObj.name +":"+ i);
 

    }
}
