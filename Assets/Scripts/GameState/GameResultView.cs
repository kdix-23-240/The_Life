using UnityEngine;
using UnityEngine.UI;

public class GameResultView : MonoBehaviour
{
    [SerializeField] private Text _gameTimeText;
    [SerializeField] private Text _aliveNum;
    [SerializeField] private Text _diedNum;
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
    public void Finish(int aliveNum, int diedNum)
    {

        _aliveNum.text = "Alive: " + aliveNum.ToString();
        _diedNum.text = "Died: " + diedNum.ToString();
        Show();
    }
}