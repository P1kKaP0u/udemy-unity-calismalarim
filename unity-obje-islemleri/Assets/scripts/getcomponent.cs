using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getcomponent : MonoBehaviour
{
    //capsulecollider türünde bir nesne
    CapsuleCollider capsuleCollider;

    // Start is called before the first frame update
    void Start()
    {

        //Parent objenin component deðerlerini deðiþtirme
        GetComponentInParent<AudioSource>().mute = true;
        GetComponentInParent<Rigidbody>().mass = 3.2f;
        

        //Child objenin component deðerlerini deðiþtirme
        GetComponentInChildren<AudioSource>().mute = true;
        GetComponentInChildren<CapsuleCollider>().enabled = true;
        





        // bir kere component tanýmlanýp obje oluþturulduktan sonra diðer metotlara ulaþýlabilir
        //ve bir kere oluþturulduðu için daha iyi performan sergiler
        capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.enabled = false;
        capsuleCollider.isTrigger = true;
        capsuleCollider.height = 7;
        

     
        CapsuleCollider[] capsuleColliders = GetComponents<CapsuleCollider>();

        for (int i = 0; i <capsuleColliders.Length; i++)
        {
            capsuleColliders[i].isTrigger = true; 
        }
       


        //Her defasýndan getcomponent komutu kullanýldýðý için düþük performans sergiler
        GetComponent<CapsuleCollider>().enabled = false;
        GetComponent<CapsuleCollider>().isTrigger = true;
        GetComponent<CapsuleCollider>().height = 7; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
