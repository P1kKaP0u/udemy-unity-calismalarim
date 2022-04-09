using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transfomvectorislemleri : MonoBehaviour
{

    //Vectorler objelerin yönlerini ve pozisyonlarýný deðiþtirmemizi saðlar 
    //Vector2 vector2;
    //Vector3 vector3;


    //Vector4 genelde gölgelendirme iþlemleri için kullanýlýr 
    //Vector4 vector4;

    //Quaternion quaternion;

    //Vector3 position1;
    //Vector3 position2;

    // Start is called before the first frame update
    void Start()
    {
        /*
        //Player pozisyon deðerlerini alma
        Debug.Log(transform.position);
        //Player scale deðerlerini alma
        Debug.Log(transform.lossyScale);
        */


        /*
        position1 = new Vector3(1f, 2f, 1f);
        position2 = new Vector3(1f, 2f, 1f);

        //vector deðerlerini string olarak alýr
        Debug.Log(position1.ToString());
        */


        //Verilen iki vector deðerinin ayný olup olmadýðýný kýyaslar
        /*
        if (position1==position2)
        {
            Debug.Log("Pozisyonlar eþit");
        }
        else
        {
            Debug.Log("Pozsiyonlar eþit deðil");
        }
        */

        
        /*
        if (Equals(position1,position2))
        {
            Debug.Log("Pozisyonlar eþit");
        }
        else
        {
            Debug.Log("Pozsiyonlar eþit deðil");
        }
        */

    }

    // Update is called once per frame
    void Update()
    {



        //Pozisyon deðerlerini 1 büyüklüðünde verir
        //Debug.Log(transform.position.normalized);


        //Vector uzunluðunun karesini alýr
        //Debug.Log(Vector3.SqrMagnitude(transform.position));


        //Vector uzunluðunu almaya yarar
        //Debug.Log(Vector3.Magnitude(transform.position));


        //Obje yer deðiþtirme iþlemi. Time.deltaTime ile her bir frame de bu iþlemi yapmasýný saðlarýz
        //ve daha kontrollü bir iþlem gerçekleþtirmiþ oluruz
        //transform.Translate(new Vector3(0.02f,0.05f,0.03f) * Time.deltaTime);
        //transform.Translate(Vector3.forward * 3f * Time.deltaTime);


    }
}
