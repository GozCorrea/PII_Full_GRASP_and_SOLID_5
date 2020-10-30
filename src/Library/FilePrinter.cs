using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeprint recipeprint)
        {
            File.WriteAllText("Recipe.txt", recipeprint.GetTextToPrint());
        }
    }
}