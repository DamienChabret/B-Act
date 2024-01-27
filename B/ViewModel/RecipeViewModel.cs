﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.ViewModel
{
    public class RecipeViewModel : INotifyPropertyChanged
    {
        private Recipe recipe;
        private int recipeId;
        private string recipeName;
        private string recipeDescription;
        private int recipeRating;

        /// <summary>
        /// ID of the recipe
        /// </summary>
        public int ID
        {
            get => recipeId; 
            set => recipeId = value;
        }

        /// <summary>
        /// Name of the recipe
        /// </summary>
        public string Name
        {
            get => recipeName;
            set => recipeName = value;
        }

        /// <summary>
        /// Decription of the recipe
        /// </summary>
        public string Description
        {
            get => recipeDescription;
            set => recipeDescription = value;
        }

        /// <summary>
        /// Rating of the recipe
        /// </summary>
        public int Rating
        {
            get => recipeRating; 
            set => recipeRating = value;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
