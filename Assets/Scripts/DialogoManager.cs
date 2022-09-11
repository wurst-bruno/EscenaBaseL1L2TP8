using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class DialogoManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] TextMeshProUGUI textoDelDialogo;
    [SerializeField] string[] frasesDialogo;
    [SerializeField] int posicionFrase;
    [SerializeField] bool hasTalked;
    [SerializeField] TextMeshProUGUI timeText;
    public float timeRemaining ;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
        timerIsRunning = false;
    }


    // Update is called once per frame
    void Update()
    {
        DisplayTime(timeRemaining);

        if (Input.GetKeyDown(KeyCode.E) && hasTalked == false)
        {
            NextFrase();
            timerIsRunning = true;

        }
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("Perdiste");

                timeRemaining = 0;
                timerIsRunning = false;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            frasesDialogo = other.gameObject.GetComponent<NPCBehavior>().Data.dialogueFrases;
            dialogueUI.SetActive(true);

            if (!hasTalked)
            {
                //al entrar activa la UI de dialogo
                textoDelDialogo.text = "Ayuda!";
            }

            else
            {
                textoDelDialogo.text = "Ya hable con vos, anda a buscar";

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            //al entrar desactiva la UI de dialogo
            dialogueUI.SetActive(false);
        }
    }

    void NextFrase()
    {
        if (posicionFrase < frasesDialogo.Length)
        {
            textoDelDialogo.text = frasesDialogo[posicionFrase];
            posicionFrase++;
        }

        else
        {
            dialogueUI.SetActive(false);
            hasTalked = true;
        }


    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
