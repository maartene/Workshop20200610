using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static public int score = 0;

    Text label;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        label = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Score: " + score;
    }
}
