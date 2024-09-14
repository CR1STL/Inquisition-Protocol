using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Player_1 : MonoBehaviour
{
    public float Speed;
    public int HP;
    private int Score;
    public TMP_Text HP_Text;
    public TMP_Text Score_Text;
    private Vector3 Pos;
    private void Update()
    {
        HP_Text.text = "HP: " + HP;
        Score_Text.text = "SCORE: " + Score.ToString();
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");
        Pos = new Vector3(Hor, Ver);
        transform.Translate(Pos.normalized * Time.deltaTime * Speed);
    }
    public void ScoreUpd()
    {
        Score += 1;
    }
    public void Damage()
    {
        HP -= 1;
        if (HP < 1)
        {
            SceneManager.LoadScene(0);
        }
    }
}