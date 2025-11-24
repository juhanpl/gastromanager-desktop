using GastroManager.DTOs;
using GastroManager.Entidades;
using GastroManager.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GastroManager.Data
{
    public class IngredientsData : IIngredientsRepository
    {
        public List<Ingredients> Select()
        {
            
            string connectionString = Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();


                string query = "SELECT * FROM Ingredients";
                List<Ingredients> ingredients = new List<Ingredients>();

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            ingredients.Add(new Ingredients()
                            {
                                AvailableCountInStock = Convert.ToInt32(reader["Available_count_in_stock"]),
                                IngredientId = Convert.ToInt32(reader["Ingredient_Id"]),
                                IngredientName = Convert.ToString(reader["Ingredient_Name"])!,
                                MainUnit = Convert.ToString(reader["Main_Unit"])!,
                                PricePerUnit = Convert.ToDecimal(reader["Price_per_Unit"])
                                
                            });

                        }

                        
                    }

                }

                return ingredients;

            }

        }

        public List<IngredientReadDTO> SelectByDishId(int Id)
        {
            string connectionString = Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();


                string query = @"SELECT 
                                I.Available_count_in_stock,
                                I.Ingredient_Name,
                                DI.Quantity,
                                I.Main_Unit,
                                I.Price_per_Unit
                                FROM Ingredients I
                                JOIN Dishes_Ingredients DI ON I.Ingredient_Id = DI.Ingredient_Id
                                WHERE DI.Dish_Id = @Id";

                List<IngredientReadDTO> ingredients = new List<IngredientReadDTO>();

                using (SqlCommand command = new SqlCommand(query, conn))
                {

                    command.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            ingredients.Add(new IngredientReadDTO()
                            {
                                AvailableCountInStock = Convert.ToInt32(reader["Available_count_in_stock"]),
                                IngredientName = Convert.ToString(reader["Ingredient_Name"])!,
                                MainUnit = Convert.ToString(reader["Main_Unit"])!,
                                PricePerUnit = Convert.ToDecimal(reader["Price_per_Unit"]),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            });

                        }


                    }

                }

                return ingredients;

            }
        }
    }
}
