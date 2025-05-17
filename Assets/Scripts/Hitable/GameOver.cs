using UnityEngine;

public class GameOver : IHitable
{
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;
    public static int DiedNum = 0;

    public GameOver(GameObject gameObject)
    {
        _gameObject = gameObject;
        _rigidbody = _gameObject.GetComponent<Rigidbody2D>();
    }
    public void Hit(Collider2D other)
    {
        Debug.Log("GameOver");
        DiedNum++;
    }
}