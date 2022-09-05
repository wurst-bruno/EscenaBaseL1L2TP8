using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosAlAzar : MonoBehaviour
{
    [SerializeField] int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerarNroAleatorio();
        }
    }

    void GenerarNroAleatorio()
    {
        randomNumber = Random.Range(0, 4);
    }
}
