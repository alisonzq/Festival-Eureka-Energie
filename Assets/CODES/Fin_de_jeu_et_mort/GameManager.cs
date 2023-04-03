using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject youWinText;
    public GameObject perdre;
    public float resetDelay;
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }
    public void Win()
    {
        youWinText.SetActive(true);
        Time.timeScale = .2f;
        Invoke("Reset", resetDelay);
    }
    public void lose()
    {
        perdre.SetActive(true);
        Time.timeScale = .2f;
        Invoke("Reset", resetDelay);
    }

    void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel);




    }
}