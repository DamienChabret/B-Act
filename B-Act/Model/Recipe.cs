namespace Model
{
    /// <summary>
    /// Class for a recipe
    /// </summary>
    public class Recipe
    {
        private int id;
        private string name;
        private string description;
        private int rating;

        /// <summary>
        /// Natural constructor of the recipe
        /// </summary>
        public Recipe()
        {
            this.name = string.Empty;
            this.description = string.Empty;
        }

        /// <summary>
        /// ID of the recipe
        /// </summary>
        public int ID 
        { 
            get => id;
            set => id = value; 
        }

        /// <summary>
        /// Name of the recipe
        /// </summary>
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        /// <summary>
        /// Description of how to make the recipe
        /// </summary>
        public string Description 
        { 
            get => description; 
            set => description = value; 
        }

        /// <summary>
        /// Rating given by the user to the recipe
        /// </summary>
        public int Rating 
        { 
            get => rating; 
            set => rating = value; 
        }
    }
}
