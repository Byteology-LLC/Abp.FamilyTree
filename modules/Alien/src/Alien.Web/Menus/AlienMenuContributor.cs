using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Alien.Web.Menus;

public class AlienMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(AlienMenus.Prefix, displayName: "Alien", "~/Alien", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
