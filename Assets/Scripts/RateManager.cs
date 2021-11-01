using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateManager : Singleton<RateManager>
{
    [SerializeField] private RateBoxPopup rateBoxPopup;
    [SerializeField] private Text playCountText;
    [HideInInspector] public int playCount;
    [HideInInspector] public bool rateOff = false;
    private int countToRate = 5;
    
    public void DisplayPopup()
    {
        int.TryParse(playCountText.text, out playCount);
        
        if(playCount % countToRate == 0 && !rateOff)
        {
            rateBoxPopup.gameObject.SetActive(true);
        }
    }
}
