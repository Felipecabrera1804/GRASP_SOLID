//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        
        /// <summary>
        /// Por patron expert, la clase step es la encargada en calcular el costo de cada paso, 
        /// esto ya que es la que tiene toda la informacion para este calculo.
        /// </summary>

        public double GetStepCost()
        {
            return this.Quantity * this.Input.UnitCost + this.Time * this.Equipment.HourlyCost;
        }
    }
}