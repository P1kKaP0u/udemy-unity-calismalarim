using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message0 : MonoBehaviour
{
    
    void Start()
    {
        /*
        gameObject.SendMessage();
        gameObject.BroadcastMessage();
        */

        //SendMessageOptions ile metot girme zorunluluðu ayarlanabilir ve hata vermesi engellenir
        //gameObject.SendMessage("ekranabasma", "Mustafa", SendMessageOptions.DontRequireReceiver);
        
        //objeden bir mesaj verme 
        gameObject.SendMessage("ekranabas", "Mustafa");

        //parent obje ile child objede bulunan ayný metotlar ile mesaj verme
        gameObject.BroadcastMessage("ekranabas2");


    }

    void ekranabas(string name)
    {
        Debug.Log("MESAJ EKRANA BASILDI: " + name);
    }

    void ekranabas2()
    {
        Debug.Log("Ben Parent objeden geliyorum");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
