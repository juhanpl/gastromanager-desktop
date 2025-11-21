using GastroManager.Entidades;
using GastroManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Logic
{
    public class DishesLogic
    {

        private readonly IDishesRepository _repo;

        public DishesLogic(IDishesRepository repo) 
        { 
        
            _repo = repo;

        }

        public List<Dishes> GetFilteredDishes(string categoryName, string dishName, bool availableIngredients, int minPrice, int maxPrice)
        {

            return _repo.Filter(categoryName, dishName, availableIngredients, minPrice, maxPrice);

        }

        public List<Dishes> GetDishes()
        {

            return _repo.Select();

        }

    }
}
