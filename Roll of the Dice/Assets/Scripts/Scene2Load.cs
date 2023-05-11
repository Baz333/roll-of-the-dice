using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Load : MonoBehaviour
{

    public GameObject enterCutscene;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    IEnumerator StartScene()
    {
        player.SetActive(false);
        yield return new WaitForSeconds(3.3f);
        enterCutscene.SetActive(false);
        player.SetActive(true);
    }
}
