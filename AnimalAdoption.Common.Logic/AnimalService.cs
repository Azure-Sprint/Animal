using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "dog", Age = 1, Description = "friendly and cute" },
            new Animal { Id = 2, Name = "pig", Age = 5, Description = "big and delicious" },
            new Animal { Id = 3, Name = "sheep", Age = 10, Description = "Good fur" },
        };
    }
}
