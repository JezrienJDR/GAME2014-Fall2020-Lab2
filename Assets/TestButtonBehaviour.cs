using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    public TMP_Text SceneLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("TestButtonPressed");
        SceneLabel.text = "Test"; 
    }
}
