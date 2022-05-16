

public abstract class ExampleControllerParent {
    public float proportionalGain = 1;
    public float integralGain = 1;
    public float derivativeGain = 1.4f;

    public float prevValue = 0;

    public abstract float[] GetPIDUpdate(float dt, float currentValue, float targetValue);
}