using System;

namespace Full_GRASP_And_SOLID
{   

    //En vez de pasar un recipe como parametro, ahora recibe un IRecipe, de esta forma rompemos con la 
    // dependencia y hacemos que el codigo sea transportable, flexible y menos fragil.
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeprint recipeprint)
        {
            Console.WriteLine(recipeprint.GetTextToPrint());
        }
    }
}