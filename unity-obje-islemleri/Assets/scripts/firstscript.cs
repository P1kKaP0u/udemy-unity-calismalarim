using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{

    public string name1;
    public int age;
    public float wage;
    private string country;
    public bool ishavecar;
    
    // Start is called before the first frame update
    void Start()
    {
        country = "New Mexico";
        Debug.Log(name1);
        Debug.Log(age);
        Debug.Log(wage);
        Debug.Log(country);
        Debug.Log(ishavecar);

        if (age>=18)
        {
            ishavecar = true;
        }
        else
        {
            ishavecar=false;
        }
     
        if (ishavecar)
        {
            Debug.Log("YES, AGE IS HIGHER 18");
        }
        else
        {
            Debug.Log("NO");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
