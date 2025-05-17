using UnityEngine;

public class KeyController : MonoBehaviour, IController
{
    [SerializeField] private float _speed = 1f;
    private float _maxX = 4.3f;
    public void Control()
    {
        if (- _maxX< this.gameObject.transform.position.x)
        {
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position += Vector3.left * _speed * Time.deltaTime;
            }
        }

        if (this.gameObject.transform.position.x < _maxX)
        {
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
            }
        }
    }
}