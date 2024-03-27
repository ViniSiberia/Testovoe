using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_script : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Game;
    public GameObject Menu;


    public void OpenSett()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }
    public void CloseSett()
    {
        Settings.SetActive(false);
        Menu.SetActive(true);
    }

    public void OpenGame()
    {
        Game.SetActive(true);
        Menu.SetActive(false);
    }
    public void CloseGame()
    {
        Game.SetActive(false);
        Menu.SetActive(true);
    }

}
