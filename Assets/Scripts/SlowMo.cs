using UnityEngine;
public class SlowMo : MonoBehaviour
{
    public float HowSlow;
    public Energy energy;
    private void Update()
    {
        Slow();
    }
    public void Slow()
    {
        if (Input.GetKey(KeyCode.Z) && energy.EnergyBar > 0f)
        {
            Time.timeScale = HowSlow;
            Time.fixedDeltaTime = Time.timeScale * 0.015f;
        }
        if (energy.EnergyBar <= 0)
        {
            Time.timeScale = 1;
        }
    }
}