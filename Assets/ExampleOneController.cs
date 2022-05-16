

public class ExampleOneController: ExampleControllerParent {
    public override float[] GetPIDUpdate(float dt, float currentValue, float targetValue) {
        float error = targetValue - currentValue;

        float P = proportionalGain * error;

        float valueChangeRate = (currentValue - prevValue) / dt;
        prevValue = currentValue;
        float D = derivativeGain * -valueChangeRate;

        return new float[] {P + D, P, D};
    } 
}