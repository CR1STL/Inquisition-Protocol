using UnityEngine;
public class Player_2 : MonoBehaviour
{
    private Vector2 A;
    private Vector2 B;
    private Transform Transform;
    private Camera Camera;
    public GameObject Bullet;
    private void Start()
    {
        A = Vector2.right;
        Camera = Camera.main;
        Transform = transform;
    }
    private void Update()
    {
        float z = Z();
        Transform.rotation = Quaternion.Euler(0, 0, z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, Quaternion.Euler(0, 0, z));
        }
    }
    private float Z()
    {
        B = Camera.ScreenToWorldPoint(Input.mousePosition) - Transform.position;
        float SC = A.x * B.x + A.y * B.y;
        float MC = A.magnitude * B.magnitude;
        float x = SC / MC;
        float Angle = Mathf.Acos(x) * Mathf.Rad2Deg * (int)side();
        return Angle;
    }
    private enum Side
    {
        L = -1,
        R = 1
    }
    private Side side()
    {
        Side side = Side.R;
        if (B.y <= A.y)
            side = Side.L;
        return side;
    }
}