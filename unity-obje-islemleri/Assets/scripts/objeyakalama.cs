using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeyakalama : MonoBehaviour
{

    GameObject myobject;
    GameObject[] multipleobject;

    public GameObject outobject;

    CapsuleCollider capsule;

    Camera cam;

     Rigidbody rb;
    void Start()
    {

        //gameobje component ekleme
        //rb = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        /*
        rb = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        rb.isKinematic = true;
        */



        //gameobje tag iþlemi
        /*
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("Evet doðru");
        }
        else
        {
            Debug.Log("Hayýr");
        }
        */



        /*
        //Obje aktif-pasif set etme
        gameObject.SetActive(true);

        //Obje aktfilik kontrolü
        if (gameObject.activeSelf)
        {
            Debug.Log(gameObject.activeSelf);
        }
        */


        //Obje type'ýna göre manipülasyon
        /*
        cam = (Camera)FindObjectOfType(typeof(Camera));

        if (cam)
        {
            Debug.Log("Eveet Camera Bulundu: " + cam.name);
        }
        else
        {
            Debug.Log("Hayýr Camera Bulunamadý");
        }
        */


        //Scriptin baðlý olduðu game objenin type'ýna manipülasyon iþlemi
        //capsule = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        /*
        capsule = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        capsule.isTrigger = true;

        if (gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
        {
            gameObject.name = "Mustafa Kemal";  
        }
        */


        //dýþarýdan verilen objeye müdahele etme
        /*
        outobject.GetComponent<firstscript>().age = 30; 
        */



        //tag a göre çoklu obje yakalama
        /*
        multipleobject = GameObject.FindGameObjectsWithTag("child");

        foreach (var item in multipleobject)
        {
            item.GetComponent<firstscript>().age = 5;
        }
        */




        //objenin tagýna göre yakalama perfomans açýsýndan daha verimlidir
        /*
        myobject = GameObject.FindWithTag("mother");
        myobject.GetComponent<firstscript>().age = 35;
        */



        //gameobject.find update metotunda kullanýlmasý önerilmez çünkü
        //oyundaki tüm sahnelerde her karede
        //arama yapacaðý için performans düþmesine sebep olabilir

        //Deðiþkene atayarak daha iyi kullanýmý saðlabilir

       /* myobject = GameObject.Find("mother");

        
        myobject.GetComponent < firstscript>().age = 25;

        GameObject.Find("mother/child").GetComponent<firstscript>().age = 10;   
        */
    }


}
