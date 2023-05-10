using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompleteCutscene;

    void OnTriggerEnter(Collider other)
    {
        levelCompleteCutscene.SetActive(true);
        //SceneManager.LoadScene("Menu");
        StartCoroutine(SwitchScenes());
    }

    IEnumerator SwitchScenes()
    {
        yield return new WaitForSeconds(3.3f);
        SceneManager.LoadScene("Menu");
    }
}
