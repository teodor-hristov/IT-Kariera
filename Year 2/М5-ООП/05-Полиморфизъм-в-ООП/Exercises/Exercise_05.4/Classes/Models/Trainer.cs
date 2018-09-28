using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_05._4
{
    class Trainer
    {
        private IAnimal entity;

        public Trainer(IAnimal entity)
        {
            Entity = entity;
        }

        public IAnimal Entity
        {
            get { return entity; }
            set { entity = value; }
        }

        public void Make()
        {
            this.entity.Perform();
        }

    }
}
