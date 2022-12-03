using UnityEngine;

namespace JoyTeam.Core.MVC
{
    public class BaseView<TModel, TController> : MonoBehaviour 
        where TModel: BaseModel
        where TController: BaseController<BaseModel>, new()
    {
        public TModel Model;
        protected TController Controller;

        public virtual void Awake() 
        {
            Controller = new TController();
            Controller.Setup(Model);
        }
    }
}