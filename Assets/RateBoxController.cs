using UnityEngine;

public class RateBoxController : MonoBehaviour
{
    RateManager rateManager;

    private void Start()
    {
        rateManager=FindObjectOfType<RateManager>();
    }
    public void ClickNoThanks()
    {
        RateManager.Instance.rateOff = true;
        gameObject.SetActive(false);
        rateManager.Reactive();
        PlayerPrefs.SetInt("Rate", 0); 
    }
    public void ClickLater()
    {
        gameObject.SetActive(false);
        rateManager.Reactive();
    }
    public void ClickRateNow()
    {
        PlayerPrefs.SetInt("Rate", 1);
        Application.OpenURL("market://details?id=application_id");
        gameObject.SetActive(false);
        rateManager.Reactive();
    }
}
