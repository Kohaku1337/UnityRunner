using UnityEngine;

public abstract class BaseState : MonoBehaviour
{
    protected PlayerMotor motor;
    public virtual void Construct() { }
    public virtual void Destruct() { }
    public virtual void Transition() { }

    private void Awake()
    {
        motor = GetComponent<PlayerMotor>();
    }

    public virtual Vector3 ProcessMotion()
    {
        Debug.Log("Пока что не разработано" + this.ToString());
        return Vector3.zero;
    }
}
