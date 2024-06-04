using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UpdateScoreOnScreen : MonoBehaviour
{
    public static UpdateScoreOnScreen Instance;

    [SerializeField] private TextMeshProUGUI myText;
    [SerializeField] private GameObject _play, _quit, _menu, _pause, _bird, _scoreText;

    private int _score;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        myText.text = _score.ToString();
    }
    public void UpdateScreenScore()
    {
        // increment the score while playing
        _score++;
        myText.text = _score.ToString();
    }
    public void Pause()
    {
        _pause.gameObject.SetActive(false);
        _bird.gameObject.SetActive(false);
        _scoreText.gameObject.SetActive(false);

        _play.gameObject.SetActive(true);
        _menu.gameObject.SetActive(true);
        _quit.gameObject.SetActive(true);

        // Pause game after click pause
        Time.timeScale = 0f;
    }
    public void Play()
    {
        _play.gameObject.SetActive(false);
        _menu.gameObject.SetActive(false);
        _quit.gameObject.SetActive(false);

        _pause.gameObject.SetActive(true);
        _bird.gameObject.SetActive(true);
        _scoreText.gameObject.SetActive(true);

        // run game after click play
        Time.timeScale = 1f;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
