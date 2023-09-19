using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    // Timer configs
    public TextMeshProUGUI timerTextMesh;
    public float startTime = 45f;
    private float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;

        timerTextMesh.text = "Time left: " + timeRemaining.ToString("F0");

        if (timeRemaining <= 0f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
