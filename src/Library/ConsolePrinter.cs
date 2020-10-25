using System;


namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        /// <summary>
        /// Se agrega Clase ConsolePrinter por SRP, se le asigna la única responsabilidad
        /// de imprimir por consola, en este caso mediante el método PrintRecipe que 
        /// imprime una receta por consola y le pide la información a Recipe que es el 
        /// experto en la información
        /// </summary>
        /// <param name="recipe"></param>
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}