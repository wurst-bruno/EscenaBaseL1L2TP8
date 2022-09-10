using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aignaasilla : MonoBehaviour
{

    [SerializeField] GameObject Silladialogo;
    [SerializeField] TextMeshProUGUI textoDelDialogo;

    // Start is called before the first frame update
    void Start()
    {
        Silladialogo.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("Silla"))
        {
            textoDelDialogo.text = "Press E";

            Silladialogo.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        // al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("Silla"))
        {
            Silladialogo.SetActive(false);
        }
    }
}
