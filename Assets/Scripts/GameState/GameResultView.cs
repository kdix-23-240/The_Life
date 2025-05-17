using UnityEngine;
using UnityEngine.UI;

public class GameResultView : MonoBehaviour
{
    [SerializeField] private Text _gameTimeText;// ゲームの経過時間
    [SerializeField] private Text _aliveNum;// 生存した命の数
    [SerializeField] private Text _diedNum;// 死亡した命の数
    public void Initialize()
    {
        Hide();
    }
    /// <summary>
    /// リザルト画面を表示する
    /// </summary>
    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    /// <summary>
    /// リザルト画面を非表示にする
    /// </summary>
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
    /// <summary>
    /// リザルト画面を更新する
    /// 生存した命の数と死亡した命の数を表示する
    /// </summary>
    /// <param name="aliveNum"></param>
    /// <param name="diedNum"></param>
    public void Finish(int aliveNum, int diedNum)
    {
        _aliveNum.text = "Alive: " + aliveNum.ToString();
        _diedNum.text = "Died: " + diedNum.ToString();
        Show();
    }
}