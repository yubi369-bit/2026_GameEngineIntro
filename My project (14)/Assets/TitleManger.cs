using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManger : MonoBehaviour
{
    public GameObject helpPanel;

    public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED!");
    }

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

    public void OpenHelp()
    {

        helpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
}
