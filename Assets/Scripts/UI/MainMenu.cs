using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   SceneManager sceneManager;
   
   public void OnClickPlayButton()
   {
      SceneManager.LoadScene("Level1");
   }

   public void OnClickExitButton()
   {
      Application.Quit();
   }
}
