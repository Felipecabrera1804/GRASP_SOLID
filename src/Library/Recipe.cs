//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        /// <summary>         
        /// Por patron expert, la clase Recipe es la encargada en calcular el total del costo          
        /// de la receta, invocando GetStepCost para cada Step de la lista. Esto ya que es la clase         
        /// experta de la información necesaria para el calculo porque conoce todos los steps por la lista        
        ///  </summary>
        public double GetProductionCost()
        {
        double CostoTotal=0;
        foreach (Step step in steps)
        {
            CostoTotal += step.GetStepCost();
            
        }
        return CostoTotal;
        }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        /// <summary>
        /// Le agregamos una invocacion a GetProductionCost al final para que se pueda ver el precio
        /// </summary>
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Precio Total: {this.GetProductionCost()}");
        }
    }
}