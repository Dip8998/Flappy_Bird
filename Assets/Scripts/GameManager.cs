using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _canvas, _none, _bronze, _silver, _gold, _PlayPause;
    [SerializeField] private TextMeshProUGUI _currentScore, _bestScore;
    
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

    }
    public void GameOver()
    {
        _PlayPause.gameObject.SetActive(false);
        _canvas.gameObject.SetActive(true);
        Time.timeScale = 0f;

        Medals();

        _currentScore.text = _score.ToString();
        _bestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void Medals()
    {
        if (_score < 25)
        {
            _none.gameObject.SetActive(true);
        }
        if (_score >= 25 && _score < 50)
        {
            _bronze.gameObject.SetActive(true);
        }
        if (_score < 25)
        {
            _none.gameObject.SetActive(true);
        }
        if (_score < 25)
        {
            _none.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _bestScore.text = _score.ToString();
        }
    }
    public void UpdateCurrentScore()
    {
        _score++;
        _currentScore.text = _score.ToString();
        UpdateHighScore();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
