using UnityEngine;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public void OnClick()
    {
        GameStateModel.Instance.SetGameState(GameStateModel.GameStateEnum.Start);
        Debug.Log("Game Restart");
    }
}  