using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transfomvectorislemleri : MonoBehaviour
{

    //Vectorler objelerin y�nlerini ve pozisyonlar�n� de�i�tirmemizi sa�lar 
    //Vector2 vector2;
    //Vector3 vector3;


    //Vector4 genelde g�lgelendirme i�lemleri i�in kullan�l�r 
    //Vector4 vector4;

    //Quaternion quaternion;

    //Vector3 position1;
    //Vector3 position2;

    // Start is called before the first frame update
    void Start()
    {
        /*
        //Player pozisyon de�erlerini alma
        Debug.Log(transform.position);
        //Player scale de�erlerini alma
        Debug.Log(transform.lossyScale);
        */


        /*
        position1 = new Vector3(1f, 2f, 1f);
        position2 = new Vector3(1f, 2f, 1f);

        //vector de�erlerini string olarak al�r
        Debug.Log(position1.ToString());
        */


        //Verilen iki vector de�erinin ayn� olup olmad���n� k�yaslar
        /*
        if (position1==position2)
        {
            Debug.Log("Pozisyonlar e�it");
        }
        else
        {
            Debug.Log("Pozsiyonlar e�it de�il");
        }
        */

        
        /*
        if (Equals(position1,position2))
        {
            Debug.Log("Pozisyonlar e�it");
        }
        else
        {
            Debug.Log("Pozsiyonlar e�it de�il");
        }
        */

    }

    // Update is called once per frame
    void Update()
    {



        //Pozisyon de�erlerini 1 b�y�kl���nde verir
        //Debug.Log(transform.position.normalized);


        //Vector uzunlu�unun karesini al�r
        //Debug.Log(Vector3.SqrMagnitude(transform.position));


        //Vector uzunlu�unu almaya yarar
        //Debug.Log(Vector3.Magnitude(transform.position));


        //Obje yer de�i�tirme i�lemi. Time.deltaTime ile her bir frame de bu i�lemi yapmas�n� sa�lar�z
        //ve daha kontroll� bir i�lem ger�ekle�tirmi� oluruz
        //transform.Translate(new Vector3(0.02f,0.05f,0.03f) * Time.deltaTime);
        //transform.Translate(Vector3.forward * 3f * Time.deltaTime);


    }
}
