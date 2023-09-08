using UnityEngine;

public class HidePanelController : MonoBehaviour
{
    [Header("Paneles")]
    
    [SerializeField] private GameObject _panelToHide;
    [SerializeField] private GameObject _panelToActive;


    // This method hides a panel and activates a panel.
    public void OpenClosePanels()
    {
        _panelToActive.SetActive(true);
        _panelToHide.SetActive(!_panelToHide);
    }
}
