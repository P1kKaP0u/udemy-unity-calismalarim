 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectdestroy : MonoBehaviour
{

    void Start()
    {
        //obje yok etme
        // Destroy(gameObject);

        //s�reli obje yok etme
        // Destroy(gameObject, 5f);

        //script yok etme
        // Destroy(this);

        //component yok etme
        Destroy(GetComponent<CapsuleCollider>());


    }


}
