using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public BgMusicController bgMusicController;
    private AudioSource audioSource;
    public AudioClip GmOver;
    public PipeSpawner PS;
    public Score score;
    public TMP_Text gameOverScoreText;
    public TMP_Text gameOverHighScoreText;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    public void GameOver(){
        gameOverPanel.SetActive(true);
        gameOverScoreText.text = "Score: " + score.CurScore;
        gameOverHighScoreText.text = "High Score: " + score.HighScore;
        PS.CancelInvoke("SpawnPipe");
        Time.timeScale = 0f;
        bgMusicController.StopMusic();
        audioSource.PlayOneShot(GmOver);

    }

    public void RestartGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}