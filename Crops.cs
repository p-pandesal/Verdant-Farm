namespace CropsPage
{
    public class Crops
    {
        private string cropName;
        private string cropClassification;
        private int cropQuantity;
        private double cropUnitCost;

        public string Name
        {
            get { return cropName; }
            set { cropName = value; }
        }

        public string Classification
        {
            get { return cropClassification; }
            set { cropClassification = value; }
        }

        public int Quantity
        {
            get { return cropQuantity; }
            set { cropQuantity = value; }
        }

        public double UnitCost
        {
            get { return cropUnitCost; }
            set { cropUnitCost = value; }
        }

        public Crops(
            string name,
            string classification,
            int quantity,
            double unitCost)
        {
            this.Name = name;
            this.Classification = classification;
            this.Quantity = quantity;
            this.UnitCost = unitCost;
        }
    }
}