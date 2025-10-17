using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
   
   public void OnClickPlayButton()
   {
      SceneManager.LoadScene("Level1");
   }

   public void OnClickExitButton()
   {
      Application.Quit();
   }
}
