using UnityEngine;
public class Player_2 : MonoBehaviour
{
    private Vector2 _one;
    private Vector2 _two;
    private Transform _thisTransform;
    private Camera _camera;
    [SerializeField] public GameObject Bullet;
    private void Start()
    {
        _one = Vector2.right;
        _camera = Camera.main;
        _thisTransform = transform;
    }
    private void Update()
    {
        float z = Z();
        _thisTransform.rotation = Quaternion.Euler(0, 0, z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, Quaternion.Euler(0, 0, z));
        }
    }
    private float Z()
    {
        _two = _camera.ScreenToWorldPoint(Input.mousePosition) - _thisTransform.position;
        float scalarComposition = _one.x * _two.x + _one.y * _two.y;
        float mudelesComposition = _one.magnitude * _two.magnitude;
        float division = scalarComposition / mudelesComposition;
        float angle = Mathf.Acos(division) * Mathf.Rad2Deg * (int)GetSide();
        return angle;
    }
    private enum Side
    {
        Left = -1,
        Right = 1
    }
    private Side GetSide()
    {
        Side side = Side.Right;
        if (_two.y <= _one.y)
            side = Side.Left;
        return side;
    }
}