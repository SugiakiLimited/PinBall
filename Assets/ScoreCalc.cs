using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalc : MonoBehaviour
{
    private GameObject Scoretext;　//スコアを表示する
    private int score = 0;　//スコア

    // Start is called before the first frame update
    void Start()
    {
        this.Scoretext = GameObject.Find("Scoretext");
        this.Scoretext.GetComponent<Text>().text = string.Format("Score:{0}", this.score);
    }

    // オブジェクト毎に得点を加算
    void OnCollisionEnter(Collision collision)
    {

        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallCloudTag")
        {
            this.score += 80;
        }
        else if (yourTag == "LargeCloudTag")
        {
            this.score += 300;
        }
        else if (yourTag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (yourTag == "LargeStarTag")
        {
            this.score += 50;
        }
        
        this.Scoretext.GetComponent<Text>().text = string.Format("Score:{0}", this.score);
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
