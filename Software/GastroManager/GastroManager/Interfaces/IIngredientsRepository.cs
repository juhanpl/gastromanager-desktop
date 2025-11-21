using GastroManager.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Interfaces
{
    public interface IIngredientsRepository
    {

        List<Ingredients> Select();
        List<Ingredients> SelectByDishId(int Id);

    }
}
