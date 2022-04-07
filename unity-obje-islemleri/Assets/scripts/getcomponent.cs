using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcomponent : MonoBehaviour
{
    //capsulecollider t�r�nde bir nesne
    CapsuleCollider capsuleCollider;

    // Start is called before the first frame update
    void Start()
    {

        //Parent objenin component de�erlerini de�i�tirme
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 3.2f;
        

        //Child objenin component de�erlerini de�i�tirme
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = true;
        





        // bir kere component tan�mlan�p obje olu�turulduktan sonra di�er metotlara ula��labilir
        //ve bir kere olu�turuldu�u i�in daha iyi performan sergiler
        capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.enabled = false;
        capsuleCollider.isTrigger = true;
        capsuleCollider.height = 7;
        

     
        CapsuleCollider[] capsuleColliders = GetComponents<CapsuleCollider>();

        for (int i = 0; i <capsuleColliders.Length; i++)
        {
            capsuleColliders[i].isTrigger = true; 
        }
       


        //Her defas�ndan getcomponent komutu kullan�ld��� i�in d���k performans sergiler
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<CapsuleCollider>().isTrigger = true;
        GetComponent<CapsuleCollider>().height = 7; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
