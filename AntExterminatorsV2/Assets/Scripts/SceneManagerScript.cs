using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
   public void LoadLevel1()
   {
      SceneManager.LoadScene("Level1");
   }

   public void LoadGameOverScene()
   {
      SceneManager.LoadScene("GameOver");
   }

   public void LoadTitleScene()
   {
      SceneManager.LoadScene("TitleScene");
   }
}
