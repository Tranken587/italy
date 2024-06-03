using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject levelMenu;
    public GameObject settingMenu;
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

    public void closeLevelMenu()
    {
        levelMenu.SetActive(false);
    }

    public void setting()
    {
        settingMenu.SetActive(true);
    }

    public void closeSettingMenu()
    {
        settingMenu.SetActive(false);
    }

    public void mute()
    {

    }

    public void unmute()
    {

    }

    // public void 
}
