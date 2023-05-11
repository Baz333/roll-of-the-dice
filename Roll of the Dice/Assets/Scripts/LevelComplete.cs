using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompleteCutscene;
    public GameObject enterText;

    /*void OnTriggerEnter(Collider other)
    {
        levelCompleteCutscene.SetActive(true);
        //SceneManager.LoadScene("Menu");
        StartCoroutine(SwitchScenes());
    }*/

    void OnTriggerEnter(Collider other)
    {
        enterText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            levelCompleteCutscene.SetActive(true);
            enterText.SetActive(false);
            StartCoroutine(SwitchScenes());

        }
    }

    void OnTriggerExit(Collider other)
    {
        enterText.SetActive(false);
    }

    IEnumerator SwitchScenes()
    {
        yield return new WaitForSeconds(3.3f);
        SceneManager.LoadScene("Level 2");
    }
}
