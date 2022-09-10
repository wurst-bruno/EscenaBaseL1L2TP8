using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipularObjetos : MonoBehaviour
{
    [SerializeField] GameObject[] sillas;
    
    // Start is called before the first frame update
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("Silla");
        AgregarRBAElementosDelArray();
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AgregarRBAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {        
            sillas[i].AddComponent<Rigidbody>();
        }        
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<BoxCollider>();
            
            
        }
    }


}
