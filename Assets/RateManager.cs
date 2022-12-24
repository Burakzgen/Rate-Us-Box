using UnityEngine;

public class RateManager : Singleton<RateManager>
{
    [SerializeField] private RateBoxController rateBox;
    public bool rateOff = false;

    [SerializeField] GameObject rateBoxCanvas;
    public void PlayButton()
    {
        if (PlayerPrefs.GetInt("Rate") == 0)
        {
            if (rateOff == false)
            {
                rateBoxCanvas.SetActive(false);
                rateBox.gameObject.SetActive(true);
            }
        }
    }
    public void Reactive()
    {
        rateBoxCanvas.SetActive(true);
    }
}
