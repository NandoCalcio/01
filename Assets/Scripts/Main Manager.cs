using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI displayPlayername;

    [SerializeField] GameObject bike;
    [SerializeField] GameObject car;
    [SerializeField] GameObject truck;

    [SerializeField] Button exitButton;

    private void Awake()
    {
        if (MenuManager.instance != null)
        {
            displayPlayername.text = MenuManager.instance.playerName;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bike == null && car == null && truck == null)
        {
            exitButton.gameObject.SetActive(true);
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
        MenuManager.instance = null;
    }
}
