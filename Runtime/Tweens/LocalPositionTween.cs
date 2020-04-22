using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalPositionTween : Tween<Vector3> {
    public override Vector3 OnGetFrom () {
      return this.transform.localPosition;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.valueCurrent.x = this.LerpValue (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = this.LerpValue (this.valueFrom.y, this.valueTo.y, easedTime);
      this.valueCurrent.z = this.LerpValue (this.valueFrom.z, this.valueTo.z, easedTime);
      this.transform.localPosition = this.valueCurrent;
    }
  }
}