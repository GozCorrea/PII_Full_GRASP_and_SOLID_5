
namespace Full_GRASP_And_SOLID
{

    //Se crea interface IRecipeprint para poder cumplir con el principio de inversion. Esta es la abstaccion
    //que encontramos para poder aplicar este principio
    public interface IRecipeprint
    {
        string GetTextToPrint();
    }
}