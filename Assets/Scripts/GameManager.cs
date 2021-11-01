using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button resetButton;
    [SerializeField] private Text displayPlayCount;
    [SerializeField] public int playCount{get; private set;} = 0;
    
    public void ProccessPlayButton()
    {
        playCount++;
        ProcessCounterText();
    }
    public void ProccessResetButton()
    {
        playCount = 0;
        ProcessCounterText();
    }
    public void ProcessCounterText()
    {
        displayPlayCount.text = playCount.ToString();
    }
}