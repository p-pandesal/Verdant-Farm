namespace EquipmentsPage
{
    public class Equipments
    {
        private string equipName;
        private string equipClassification;
        private int equipQuantity;
        private double equipUnitCost;

        public string Name
        {
            get { return equipName; }
            set { equipName = value; }
        }

        public string Classification
        {
            get { return equipClassification; }
            set { equipClassification = value; }
        }

        public int Quantity
        {
            get { return equipQuantity; }
            set { equipQuantity = value; }
        }

        public double UnitCost
        {
            get { return equipUnitCost; }
            set { equipUnitCost = value; }
        }

        public double TotalCost
        {
            get { return equipQuantity * equipUnitCost; }
        }

        public Equipments(string name, string classification, int quantity, double unitCost)
        {
            this.Name = name;
            this.Classification = classification;
            this.Quantity = quantity;
            this.UnitCost = unitCost;
        }
    }
}