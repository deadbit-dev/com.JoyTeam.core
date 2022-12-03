namespace JoyTeam.Core.MVC
{
    public class BaseController<TModel> where TModel: BaseModel
    {
        protected TModel Model;

        public virtual void Setup(TModel model) => Model = model;

    }
}