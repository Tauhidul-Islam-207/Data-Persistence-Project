using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    public static PlayerDataHandle instance;

    public string playerName;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
