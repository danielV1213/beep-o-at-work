using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLogic : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject confPanel;
    public GameObject principalPanel;

    public void buttonResume()
    {
        this.gameObject.SetActive(false);
    }

    public void buttonOpenConfiguration()
    {
        principalPanel.SetActive(false);
        confPanel.SetActive(true);
    }

    public void buttonCloseConfiguration()
    {
        principalPanel.SetActive(true);
        confPanel.SetActive(false);
    }


    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void buttonExitGame()
    {
        Application.Quit();
    }



}
