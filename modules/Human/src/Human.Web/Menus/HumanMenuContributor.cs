using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Human.Web.Menus;

public class HumanMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(HumanMenus.Prefix, displayName: "Human", "~/Human", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
