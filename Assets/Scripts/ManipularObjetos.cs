using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField] GameObject[] sillas;
    [SerializeField] int index;
    [SerializeField] GameObject SillaEspecial;
    
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
        index = Random.Range(0, sillas.Length);
        SillaEspecial = sillas[index];
        //AgregarRBAElementosDelArray();
        AgregarColliderAElementosDelArray();
    }

   
    void Update()
    {
        
    }
    
    //void AgregarRBAElementosDelArray()
    //{

    //    sillas[index].AddComponent<Rigidbody>();

    //}

    void AgregarColliderAElementosDelArray()
    {
        sillas[index].AddComponent<BoxCollider>();
    }


}
