using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions
{

    [Category("Trigonometry")]
    public class GetASine : ActionTask
    {
        public BBParameter<float> Value;
        public BBParameter<bool> RadToDeg = true;
        [BlackboardOnly]
        public BBParameter<float> angle;
        protected override void OnExecute()
        {
            float _angle = Mathf.Asin(Value.value);
            if (RadToDeg.value)
            {
                _angle = _angle * Mathf.Rad2Deg;
            }

            angle.value = _angle;
            EndAction();
        }
    }
}