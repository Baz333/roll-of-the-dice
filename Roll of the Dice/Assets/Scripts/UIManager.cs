using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public Animator buttons;
    public Animator dialog;

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OpenSettings()
    {
        buttons.SetBool("isHidden", true);
        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        buttons.SetBool("isHidden", false);
        dialog.SetBool("isHidden", true);
    }

}
