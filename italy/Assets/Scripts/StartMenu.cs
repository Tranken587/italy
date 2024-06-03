using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelMenu;
    public GameObject volumeMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectLevel()
    {
        levelMenu.SetActive(true);
    }

    public void select1()
    {
        SceneManager.LoadScene("level1");
    }

    public void changeVolume()
    {
        volumeMenu.SetActive(true);
    }
}
