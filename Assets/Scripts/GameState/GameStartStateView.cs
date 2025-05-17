using UnityEngine;
using UnityEngine.UI;

public class GameStartStateView : MonoBehaviour
{
    public void Initialize()
    {
        Show();
    }
    /// <summary>
    /// ゲームスタート画面を表示する
    /// </summary>
    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    /// <summary>
    /// ゲームスタート画面を非表示にする
    /// </summary>
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}