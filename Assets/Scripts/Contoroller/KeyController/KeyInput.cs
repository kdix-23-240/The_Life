using UnityEngine;

/// <summary>
/// キーボード入力による操作を受け取るクラス
/// </summary>
public class KeyInput : MonoBehaviour, IController
{
    private KeyControllerModel _model;
    private KeyControllerPresenter _presenter;

    void Start()
    {
        this._presenter = GetComponent<KeyControllerPresenter>();
        this._model = this._presenter.GetKeyControllerModel();
    }

    void Update()
    {
        Control();
    }
    /// <summary>
    /// キーボード入力による操作を行う
    /// </summary>
    public void Control()
    {
        // 左右の移動
        // 左端にいなければ、移動できる
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _model.AButtonPressed.Value = true;
        }
        else
        {
            _model.AButtonPressed.Value = false;
        }

        // 右に移動
        // 右端にいなければ、移動できる
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _model.DButtonPressed.Value = true;
        }
        else
        {
            _model.DButtonPressed.Value = false;
        }
    }
}