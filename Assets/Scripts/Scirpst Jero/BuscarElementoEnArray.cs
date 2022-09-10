using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscarElementoEnArray : MonoBehaviour
{

    [SerializeField] GameObject[] arrayDeMesas;
    [SerializeField] string tagDeMesa;

    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag(tagDeMesa);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            FindObjectInArray();
        }
    }

    void FindObjectInArray()
    {
        int i = 0;
        while (i<arrayDeMesas.Length)
        {
            if (arrayDeMesas[i].GetComponent<Mesa>().owner == "Jeronimo")
            {
                Destroy(arrayDeMesas[i]);
                return;
            }
            i++;
        }
    }
}
