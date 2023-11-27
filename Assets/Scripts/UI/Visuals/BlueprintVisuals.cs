using Nova;
using Unity.VisualScripting;


public class BlueprintVisuals : ItemVisuals
{
    public UIBlock ContentRoot;
    public TextBlock Description;

    public void Bind(BuildableDescription data)
    {
        if (data.IsEmpty) {
            ContentRoot.gameObject.SetActive(false);
        } else {
            ContentRoot.gameObject.SetActive(true);
            Description.Text = data.description;
        }
    }
}
