using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public void OnClick()
    {
        GameStateModel.Instance.SetGameState(GameStateModel.GameStateEnum.Playing);
    }
}  