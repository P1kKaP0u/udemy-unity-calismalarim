using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{


    public string[] childs;

    public List<string> dads;
        
    // Start is called before the first frame update
    void Start()
    {
        dads.Add("Mustafa");
        
       

        foreach (var item in childs)
        {
            Debug.Log(item);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
