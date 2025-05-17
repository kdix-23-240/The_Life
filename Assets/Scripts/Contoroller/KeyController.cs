using UnityEngine;

public class KeyController : MonoBehaviour, IController
{
    [SerializeField] private float _speed = 1f;
    public void Control()
    {
        if (-5 < this.gameObject.transform.position.x)
        {
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position += Vector3.left * _speed * Time.deltaTime;
            }
        }

        if (this.gameObject.transform.position.x < 5)
        {
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
            }
        }
    }
}