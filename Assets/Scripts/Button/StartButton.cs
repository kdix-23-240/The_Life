using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    void OnClick()
    {
        GameStateModel.Instance.SetGameState(GameStateModel.GameStateEnum.Playing);
        Debug.Log("Game Start");
    }
}  