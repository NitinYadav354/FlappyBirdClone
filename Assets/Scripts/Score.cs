using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    bool isUpdated = false;
    public TMP_Text ScoreText;
    public int CurScore = 0;
    public PipeSpawner PS;
    public TMP_Text HighScoreText;
    public int HighScore;
    private AudioSource audioSource;
    public AudioClip GmHs;
    private int oldHighScore;
    public PlayerController player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        CurScore += 1;
        UpdateScoreText();
        checkHighScore();
        if (CurScore % 10 == 0 && CurScore != 0)
        {
            PS.spawnRate = Mathf.Max(1.5f, PS.spawnRate - 0.1f);
            PS.UpdateSpawnRate();
            player.gS += 0.1f;
        }
    }

    private void Start() {
        isUpdated = false;
        UpdateScoreText();
        HighScore = PlayerPrefs.GetInt("HighScore", 1);
        UpdateHighScoreText();
        audioSource = GetComponent<AudioSource>();
        oldHighScore = HighScore;
    }

    void UpdateScoreText(){
        ScoreText.text = "Score:"+CurScore;
    }

    void UpdateHighScoreText(){
        HighScoreText.text = "High Score:" + HighScore;
    }

    void checkHighScore(){
        if(CurScore>HighScore) {
            HighScore = CurScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
            PlayerPrefs.Save();
            UpdateHighScoreText();
            if (HighScore > oldHighScore && isUpdated == false)
            {
                audioSource.PlayOneShot(GmHs);
                isUpdated = true;
            }
        }
    }
}
