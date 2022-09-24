using JoyTeam.Core;

// ######################################
//              FOR EXAMPLE
// ######################################

public class Controller : Singleton<Controller> {
    public override void Init() {
        // Bad
        StartCoroutine(Extentions.ActionWithDelay(() => {
            // DO SOMETHING
        }, 0.5f));

        // Better
        Extentions.ActionWithDelay(this, () => {
            // DO SOMETHING
        }, 0.5f);

        // Best
        Instance.ActionWithDelay(() => {
            // DO SOMETHING
        }, 0.5f);
    } 
}