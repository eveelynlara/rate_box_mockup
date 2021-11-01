using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateBoxPopup : MonoBehaviour
{
    [SerializeField] private Button noThanks;
    [SerializeField] private Button later;
    [SerializeField] private Button rateNow;
    public void NoThanks()
    {
        RateManager.GetInstance().rateOff = true;
        gameObject.SetActive(false);
    }

    public void Later()
    {
        gameObject.SetActive(false);
    }

    public void RateNow()
    {
        Application.OpenURL("market://details?id=com.xxx.xxx");
        gameObject.SetActive(false);
    }
}