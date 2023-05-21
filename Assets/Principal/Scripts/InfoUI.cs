using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoUI : MonoBehaviour
{
    public static int pontos;
    public float countdownTime = 60f; // Tempo inicial do temporizador
    public TextMeshProUGUI countdownText; // Referência ao objeto de texto para exibir o temporizador
    public TextMeshProUGUI countPoints; // Contador de pontos

    public GameObject[] comandas;

    private void Start()
    {
        StartCoroutine(StartCountdown());         
    }
    private void Update()
    {
        ShowPoints();
    }
    public void ShowPoints()
    {
        countPoints.text = pontos.ToString("");
    }
    private IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            int minutes = Mathf.FloorToInt(countdownTime / 60);
            int seconds = Mathf.FloorToInt(countdownTime % 60);

            countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Formato "00:00" para minutos e segundos
            yield return new WaitForSeconds(1f); // Aguarda 1 segundo
            countdownTime--; // Decrementa o tempo
        }

        countdownText.text = "Tempo esgotado!";
    }
}
