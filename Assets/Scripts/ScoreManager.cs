using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoretext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoretext.text = score.ToString();
        score++;
    }
}
