using UnityEngine;
using UnityEngine.UI;

public class GameResultView : MonoBehaviour
{
    public void Initialize()
    {
        Hide();
    }
    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}