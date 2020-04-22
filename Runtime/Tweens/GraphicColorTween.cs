using UnityEngine;
using UnityEngine.UI;

namespace UnityPackages.Tweens {
  public class GraphicColorTween : Tween<Color> {
    private bool hasGraphic;
    private Graphic graphic;

    public override Color OnGetFrom () {
      this.graphic = this.gameObject.GetComponent<Graphic> ();
      this.hasGraphic = this.graphic != null;
      return this.hasGraphic == true ? this.graphic.color : Color.white;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      if (this.hasGraphic == true) {
        this.valueCurrent.r = this.LerpValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.LerpValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.LerpValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.LerpValue (this.valueFrom.a, this.valueTo.a, easedTime);
        this.graphic.color = this.valueCurrent;
      }
    }
  }
}