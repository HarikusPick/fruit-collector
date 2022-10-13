using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{

  private Text canvasText;
  private AudioSource audio;

  private int currentScore = 0;

  // Start is called before the first frame update
  void Start()
  {
    canvasText = GameObject.Find("score").GetComponent<Text>();
    canvasText.text = "0";

    audio = GetComponent<AudioSource>();
  }

  // Update is called once per frame
  void OnTriggerEnter2D(Collider2D other)
  {

    if (other.tag == "bomb")
    {
      Destroy(other.gameObject);
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    if (other.tag == "fruit")
    {
      Destroy(other.gameObject);
      currentScore++;
      canvasText.text = currentScore.ToString();
      audio.Play();
    }

  }
}
