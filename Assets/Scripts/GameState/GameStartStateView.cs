using UnityEngine;
using UnityEngine.UI;

public class GameStartStateView : MonoBehaviour
{
    [SerializeField] private GameObject _popup;

    public void Initialize()
    {
        Show();
    }
    public void Show()
    {
        _popup.SetActive(true);
    }
    public void Hide()
    {
        _popup.SetActive(false);
    }
}