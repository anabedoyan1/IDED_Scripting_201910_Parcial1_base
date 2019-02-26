namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {            
        }

        public void Upgrade()
        {
            switch (Level)
            {
                case (0):                    
                    break;
                case (1):
                    speedBonus = (speedBonus * 3) / 100;
                    break;
                case (2):
                    speedBonus = (speedBonus * 3) / 100;
                    break;
                case (3):
                    speedBonus = (speedBonus * 3) / 100;
                    break;
            }
        }
    }
}