using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Species.Web.Menus;

public class SpeciesMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(SpeciesMenus.Prefix, displayName: "Species", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
