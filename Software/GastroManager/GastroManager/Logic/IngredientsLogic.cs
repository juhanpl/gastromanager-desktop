using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class IngredientsLogic
    {

        private IIngredientsRepository _repo;

        public IngredientsLogic(IIngredientsRepository repo) 
        {
        
            _repo = repo;

        }

        public List<Ingredients> GetIngredients()
        {

            return _repo.Select();

        }

    }
}
