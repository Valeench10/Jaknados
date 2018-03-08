using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class abrirmenu : MonoBehaviour {

    public GameObject UISettingsmenu;
    public GameObject UIInventory;

    public void abrirsettings()
    {
        UISettingsmenu.SetActive(true);
    }

    public void cerrarsettings()
    {
        UISettingsmenu.SetActive(false);
    }

    public void legendarylevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void regularlevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
