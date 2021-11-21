using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenceSwitch : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown((KeyCode.G)))
        {
            Switch();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SwitchBack();
        }
    }

    public void Switch()
    {
        // Load the Scence
        StartCoroutine(LoadScence(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void SwitchBack()
    {
        StartCoroutine(LoadScence(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadScence(int Index)
    {
        //Play our animation
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);

        //Wait
        SceneManager.LoadScene(Index);

    }

}
