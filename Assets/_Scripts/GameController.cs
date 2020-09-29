using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    private bool hasSafeArea = false;

    // Start is called before the first frame update
    void Start()
    {

        hasSafeArea = !(Screen.width == Screen.safeArea.width && Screen.height == Screen.safeArea.height);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //Debug.Log(Screen.orientation.ToString());

        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -200.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -200.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -80.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                break;
            case ScreenOrientation.LandscapeLeft:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -80.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -80.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-350.0f, -80.0f);
                }
                    break;
            case ScreenOrientation.LandscapeRight:
                if (hasSafeArea)
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -80.0f);
                }
                else
                {
                    LivesLabel.rectTransform.anchoredPosition = new Vector2(250.0f, -80.0f);
                    ScoreLabel.rectTransform.anchoredPosition = new Vector2(-250.0f, -80.0f);
                }
                    break;
            case ScreenOrientation.Unknown:
                SceneLabel.text = "UNKNOWN";
                break;
        }
    }
}
