using System;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter 
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.PrintRecipe());
        }
    }
}