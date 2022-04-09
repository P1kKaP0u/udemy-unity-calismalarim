using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorislemleri : MonoBehaviour
{
    //Static Methodlar

    public Transform hedef;
    public Transform hedef2;

    private float bas_zaman;

    void Start()
    {
        bas_zaman = Time.time;

        /*
            Time.time
            Time.deltaTime
            T�me.timeScale
        */


    }

    
    void Update()
    {


        // learp iki vekt�r aras�nda do�rusal bir �izgi olu�turulmas�n� sa�lar
        transform.position = Vector3.Lerp(hedef.position, hedef2.position, (Time.time - bas_zaman) * .2f);
         


        // distance iki vekt�r aras�ndaki mesafeyi d�nd�r�r
        /*
        float fark = Vector3.Distance(hedef.position,transform.position);

        Debug.Log("Aradaki Mesafe: " + fark);
        */



        // angel iki vekt�r aras�ndaki fark� derece cinsinden verir
        /*
        Vector3 mesafe = hedef.position - transform.position;

        float angle = Vector3.Angle(mesafe, transform.up);

        Debug.Log(angle);

        if (angle < 5f)
        {
            Debug.Log("A�� Sa�land�");
        }
        */

    }
}
