using UnityEngine;
using UnityEngine.UI;

public class GameStartStateView : MonoBehaviour
{

    public void Initialize()
    {
        Show();
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