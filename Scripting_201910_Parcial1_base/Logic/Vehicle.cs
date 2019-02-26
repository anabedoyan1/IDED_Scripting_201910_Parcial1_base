namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        //Lo siento profe, no sé utilizar esas pruebas, practiqué con puro Program. No comprendo qué debo hacer :/
        //y sé qué es de mi total responsabilidad, pues no caí en cuenta del detalle de las unitTest.
        protected float baseMaxSpeed;

        protected int Level { get; set; }

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return 0F;
            }
            set
            {
                value = MaxSpeed;
            }
        }

        public Vehicle()
        {
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (Type == part.Type || part.Type == VehicleType.Any)
            {
                CurrentPart = part as Turbo;
                result = true;
            }
            if(part.Type == VehicleType.Bike)
            {
                CurrentPart = part as Muffler;
                result = true;
            }
            if (part.Type == VehicleType.Car)
            {
                CurrentPart = part as Nitro;
                result = true;
            }
            if(part.Type == VehicleType.None)
            {
                MaxSpeed = baseMaxSpeed;
                result = true;
            }

            return result;
        }

        public void Upgrade()
        {
            switch (Level)
            {
                case (0):
                    break;
                case (1):
                    baseMaxSpeed = (baseMaxSpeed * 5) / 100;
                    break;
                case (2):
                    baseMaxSpeed = (baseMaxSpeed * 5) / 100;
                    break;
                case (3):
                    baseMaxSpeed = (baseMaxSpeed * 5) / 100;
                    break;
            }
        }
    }
}