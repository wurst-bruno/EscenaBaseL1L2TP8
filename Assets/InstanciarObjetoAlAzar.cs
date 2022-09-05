using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObjetoAlAzar : MonoBehaviour
{
    [SerializeField] GameObject[] objetosAInstanciar;
    bool puedeInstanciar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (puedeInstanciar)
            {
                InstanciarObjeto(objetosAInstanciar[Random.Range(0, objetosAInstanciar.Length)]);
            }
            
        }
    }

    void InstanciarObjeto(GameObject objeto)
    {
        objeto.AddComponent<BoxCollider>();
        objeto.AddComponent<Rigidbody>();
        Instantiate(objeto,transform.position,transform.rotation);
        StartCoroutine(EsperarSegundos(1));
    }

    IEnumerator EsperarSegundos(float t)
    {
        puedeInstanciar = false;
        yield return new WaitForSeconds(t);
        puedeInstanciar = true;
    }
}
