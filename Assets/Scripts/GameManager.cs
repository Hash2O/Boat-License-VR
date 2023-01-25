using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioSource _musiqueDuJeu;
    //[SerializeField] private GameObject _gameOverScreen;
    //[SerializeField] private List<Scene> _sceneList;

    private float timeToWait = 3.0f;

    public float timeRemaining = 120;
    public bool timerIsRunning = false;
    //public TMP_Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        //compteur = 0;
        //StartCoroutine(waitThreeSeconds()); //Ca fonctionne

        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator waitThreeSeconds()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait);
            print("APRES " + timeToWait + " SECONDES, ON PEUT AFFICHER CE QU'ON VEUT");
        }
    }

    /*
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = "Remaining time : " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    */
}
