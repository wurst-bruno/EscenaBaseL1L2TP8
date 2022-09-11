using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aignaasilla : MonoBehaviour
{

    [SerializeField] GameObject CanvasSilla;
    [SerializeField] TextMeshProUGUI textoDeSilla;
    [SerializeField] GameObject WinUI;
    [SerializeField] TextMeshProUGUI win;


    // Start is called before the first frame update
    void Start()
    {
        CanvasSilla.SetActive(false);
        WinUI.SetActive(false);
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
            textoDeSilla.text = "Press E";

            CanvasSilla.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        // al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("Silla"))
        {
            CanvasSilla.SetActive(false);
        }
    }
}
