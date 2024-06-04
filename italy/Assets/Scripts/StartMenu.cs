using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelMenu;
    public GameObject optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(levelMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                closeLevelMenu();
            }
        }
        else if(optionsMenu.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                closeOptionsMenu();
            }
        }
    }

    public void selectLevel()
    {
        levelMenu.SetActive(true);
    }

    public void select1()
    {
        SceneManager.LoadScene("level1");
    }

    public void closeLevelMenu()
    {
        levelMenu.SetActive(false);
    }

    public void options()
    {
        optionsMenu.SetActive(true);
    }

    public void closeOptionsMenu()
    {
        optionsMenu.SetActive(false);
    }

    public void mute()
    {

    }

    // public void 
}
