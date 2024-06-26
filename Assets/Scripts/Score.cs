using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Update score while playing
            UpdateScoreOnScreen.Instance.UpdateScreenScore();
            // display the score if the player die
            GameManager.Instance.UpdateCurrentScore();
        }
    }
}
