using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kalah : MonoBehaviour
{
  public void TryAgain()
  {
      SceneManager.LoadScene("MainScene");
  }
  
  public void BackMenu()
  {
      SceneManager.LoadScene("MainMenu");
  }
}
