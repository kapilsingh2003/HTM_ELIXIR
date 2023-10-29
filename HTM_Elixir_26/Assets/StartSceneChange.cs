using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    public void changeScenePhysicsMenu()
    {
        SceneManager.LoadScene("PhysicsMenu");
    }
    public void changeSceneEngine()
    {
        SceneManager.LoadScene("Physics");
    }
    public void changeSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void changeSceneChemistryMenu()
    {
        SceneManager.LoadScene("ChemistryMenu");
    }
    public void changeSceneAlkanes()
    {
        SceneManager.LoadScene("Alkanes");
    }
    public void changeScenetitrations()
    {
        SceneManager.LoadScene("titrations");
    }
    public void changeSceneKetAlde()
    {
        SceneManager.LoadScene("KetAlde");
    }
    public void changeSceneBioMenu()
    {
        SceneManager.LoadScene("BioMenu");
    }
    public void changeScenecell()
    {
        SceneManager.LoadScene("cell");
    }
    public void changeSceneHomePage()
    {
        SceneManager.LoadScene("HomePage");
    }
    public void changeScenevrmenu()
    {
        SceneManager.LoadScene("vrmenu");
    }
    public void changeScenePlaneDet()
    {
        SceneManager.LoadScene("PlaneDet");
    }
}
