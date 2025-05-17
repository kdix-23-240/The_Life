using UnityEngine;
using UnityEngine.UI;

public class GameResultView : MonoBehaviour
{
    [SerializeField] private GameObject _popup;

    public void Initialize()
    {
        Hide();
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