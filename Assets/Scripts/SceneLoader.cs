using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System.Linq.Expressions;
using UnityEditor.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Button sceneButtonOne;
    [SerializeField] Button sceneButtonTwo;
    [SerializeField] Button sceneButtonThree;
    [SerializeField] Button backButton;
    [SerializeField] int sceneIndex;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (backButton == null)
        {
            sceneButtonOne.onClick.AddListener(OnButtonOneClick);
            sceneButtonTwo.onClick.AddListener(OnButtonTwoClick);
            sceneButtonThree.onClick.AddListener(OnButtonThreeClick);

        }

        else 
        {
            backButton.onClick.AddListener(OnBackButtonClick);
        }
    }

    

    private void OnButtonOneClick()
    {

        UnityEngine.Debug.Log("Button One Clicked");
        SceneManager.LoadScene(sceneIndex + 1, LoadSceneMode.Single);
        Destroy(this);
                             
    }

    private void OnButtonTwoClick()
    {

        UnityEngine.Debug.Log("Button Two Clicked");
        SceneManager.LoadScene(sceneIndex + 2, LoadSceneMode.Single);

    }

    private void OnButtonThreeClick()
    {

        UnityEngine.Debug.Log("Button Three Clicked");
        SceneManager.LoadScene(sceneIndex + 3, LoadSceneMode.Single);

    }

    private void OnBackButtonClick()
    {

        UnityEngine.Debug.Log("Back Button Clicked");
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);

    }
}
