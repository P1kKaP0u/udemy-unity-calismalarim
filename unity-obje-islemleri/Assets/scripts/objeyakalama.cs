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



        //gameobje tag i�lemi
        /*
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("Evet do�ru");
        }
        else
        {
            Debug.Log("Hay�r");
        }
        */



        /*
        //Obje aktif-pasif set etme
        gameObject.SetActive(true);

        //Obje aktfilik kontrol�
        if (gameObject.activeSelf)
        {
            Debug.Log(gameObject.activeSelf);
        }
        */


        //Obje type'�na g�re manip�lasyon
        /*
        cam = (Camera)FindObjectOfType(typeof(Camera));

        if (cam)
        {
            Debug.Log("Eveet Camera Bulundu: " + cam.name);
        }
        else
        {
            Debug.Log("Hay�r Camera Bulunamad�");
        }
        */


        //Scriptin ba�l� oldu�u game objenin type'�na manip�lasyon i�lemi
        //capsule = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;
        /*
        capsule = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;
        capsule.isTrigger = true;

        if (gameObject.GetComponent("CapsuleCollider") as CapsuleCollider)
        {
            gameObject.name = "Mustafa Kemal";  
        }
        */


        //d��ar�dan verilen objeye m�dahele etme
        /*
        outobject.GetComponent<firstscript>().age = 30; 
        */



        //tag a g�re �oklu obje yakalama
        /*
        multipleobject = GameObject.FindGameObjectsWithTag("child");

        foreach (var item in multipleobject)
        {
            item.GetComponent<firstscript>().age = 5;
        }
        */




        //objenin tag�na g�re yakalama perfomans a��s�ndan daha verimlidir
        /*
        myobject = GameObject.FindWithTag("mother");
        myobject.GetComponent<firstscript>().age = 35;
        */



        //gameobject.find update metotunda kullan�lmas� �nerilmez ��nk�
        //oyundaki t�m sahnelerde her karede
        //arama yapaca�� i�in performans d��mesine sebep olabilir

        //De�i�kene atayarak daha iyi kullan�m� sa�labilir

       /* myobject = GameObject.Find("mother");

        
        myobject.GetComponent < firstscript>().age = 25;

        GameObject.Find("mother/child").GetComponent<firstscript>().age = 10;   
        */
    }


}
