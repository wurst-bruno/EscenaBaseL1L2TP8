using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoManager : MonoBehaviour
{

    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // al entrar activa la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            textoDelDialogo.text = " Hola forastero ! ";

            dialogueUI.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        // al salir desactiva la UI de diálogo
        if (other.gameObject.CompareTag("NPC"))
        {
            dialogueUI.SetActive(false);
        }
    }
}
