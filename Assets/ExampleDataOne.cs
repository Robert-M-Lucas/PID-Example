using UnityEngine;

public class ExampleDataOne: ExampleData {
    public new ExampleControllerParent controller = new ExampleOneController();

    public void FixedUpdate() {
        if (!active) { return; }
        float[] update = controller.GetPIDUpdate(Time.fixedDeltaTime, Mover.transform.position.x, Targets[currentTarget].position.x);
        Mover.FullForce.localPosition =    new Vector3(update[0], Mover.FullForce.localPosition.y,    Mover.FullForce.localPosition.z   );
        Mover.Proportional.localPosition = new Vector3(update[1], Mover.Proportional.localPosition.y, Mover.Proportional.localPosition.z);
        Mover.Derivative.localPosition =   new Vector3(update[2], Mover.Derivative.localPosition.y,   Mover.Derivative.localPosition.z  );
        Mover.rb.AddForce(Vector3.right * update[0] * power * Time.fixedDeltaTime);
    }
}