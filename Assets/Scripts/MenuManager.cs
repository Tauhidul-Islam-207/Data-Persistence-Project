using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Text nameText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartClick()
    {
        SceneManager.LoadScene("main");
    }

    public void SetName()
    {
        PlayerDataHandle.instance.playerName = nameText.text;
    }
}
