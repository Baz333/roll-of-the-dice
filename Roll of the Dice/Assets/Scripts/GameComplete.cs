using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{

    public GameObject money;
    public GameObject gameCompleteCutscene;
    public GameObject completeText;
    public GameObject player;
    public GameObject congratulationsText;

    void OnTriggerEnter(Collider other)
    {
        money.SetActive(true); 
        completeText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.SetActive(false);
            gameCompleteCutscene.SetActive(true);
            completeText.SetActive(false);
            congratulationsText.SetActive(true);
            StartCoroutine(SwitchScenes());
        }
    }

    void OnTriggerExit(Collider other)
    {
        completeText.SetActive(false);
    }

    IEnumerator SwitchScenes()
    {
        yield return new WaitForSeconds(3.3f);
        SceneManager.LoadScene("Menu");
    }

}
