﻿using DeWaste.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeWaste.Models.ViewModels
{
    class ItemViewModel : BindableBase
    {
        private Item item;

        private bool[] categories = new bool[13];
        private bool[] toggles = new bool[13];
        
        public ItemViewModel()
        {
            item = new Item
            {
                img = "/Assets/Images/logo.png",
                description = "Go to search and search for something in order to display.",
                name = "Example item"
            };
            updateUI();
        }

        private void updateUI()
        {
            OnPropertyChanged("ItemDescription");
            OnPropertyChanged("ItemName");
            OnPropertyChanged("ItemImage");

            OnPropertyChanged("PlasticVisibility");
            OnPropertyChanged("PaperVisibility");
            OnPropertyChanged("MetalVisibility");
            OnPropertyChanged("WoodVisibility");
            OnPropertyChanged("TextileVisibility");
            OnPropertyChanged("GlassVisibility");
            OnPropertyChanged("CombinedVisibility");
            OnPropertyChanged("BulkyVisibility");
            OnPropertyChanged("DirtyVisibility");
            OnPropertyChanged("DepositVisibility");
            OnPropertyChanged("EWasteVisibility");
            OnPropertyChanged("ContaminatedVisibility");
        }

        private void clearToggles()
        {
            for (int i = 0; i < toggles.Length; i++)
            {
                toggles[i] = false;
            }
        }

        private void updateToggles()
        {
            OnPropertyChanged("PlasticToggle");
            OnPropertyChanged("PaperToggle");
            OnPropertyChanged("MetalToggle");
            OnPropertyChanged("WoodToggle");
            OnPropertyChanged("TextileToggle");
            OnPropertyChanged("GlassToggle");
            OnPropertyChanged("CombinedToggle");
            OnPropertyChanged("BulkyToggle");
            OnPropertyChanged("DirtyToggle");
            OnPropertyChanged("DepositToggle");
            OnPropertyChanged("EWasteToggle");
            OnPropertyChanged("ContaminatedToggle");
        }

        public void setToggle(int id)
        {
            clearToggles();
            toggles[id] = true;
            updateToggles();
        }

        public bool PlasticToggle
        {
            get { return toggles[1]; }
            set
            {
                SetProperty(ref toggles[1], value);
            }
        }

        public bool PaperToggle
        {
            get { return toggles[2]; }
            set
            {
                SetProperty(ref toggles[2], value);
            }
        }

        public bool MetalToggle
        {
            get { return toggles[3]; }
            set
            {
                SetProperty(ref toggles[3], value);
            }
        }

        public bool WoodToggle
        {
            get { return toggles[4]; }
            set
            {
                SetProperty(ref toggles[4], value);
            }
        }

        public bool TextileToggle
        {
            get { return toggles[5]; }
            set
            {
                SetProperty(ref toggles[5], value);
            }
        }

        public bool GlassToggle
        {
            get { return toggles[6]; }
            set
            {
                SetProperty(ref toggles[6], value);
            }
        }

        public bool CombinedToggle
        {
            get { return toggles[7]; }
            set
            {
                SetProperty(ref toggles[7], value);
            }
        }

        public bool BulkyToggle
        {
            get { return toggles[8]; }
            set
            {
                SetProperty(ref toggles[8], value);
            }
        }

        public bool DirtyToggle
        {
            get { return toggles[12]; }
            set
            {
                SetProperty(ref toggles[12], value);
            }
        }

        public bool DepositToggle
        {
            get { return toggles[10]; }
            set
            {
                SetProperty(ref toggles[10], value);
            }
        }

        public bool EWasteToggle
        {
            get { return toggles[11]; }
            set
            {
                SetProperty(ref toggles[11], value);
            }
        }

        public bool ContaminatedToggle
        {
            get { return toggles[9]; }
            set
            {
                SetProperty(ref toggles[9], value);
            }
        }


        private void updateCategories()
        {
            for(int i = 0; i < categories.Length; i++)
            {
                categories[i] = false;
            }
            foreach(Category category in item.categories)
            {
                categories[category.id] = true;
            }
        }

        

        public void SetItem(Item item)
        {
            this.item = item;
            item.img = "/Assets/Images/Items/" + item.img; 
            updateCategories();
            updateUI();
            clearToggles();
            updateToggles();
        }

        public bool PlasticVisibility
        {
            get => categories[1];
            set
            {
                SetProperty(ref categories[1], value);
            }
        }

        public bool PaperVisibility
        {
            get => categories[2];
            set
            {
                SetProperty(ref categories[2], value);
            }
        }

        public bool MetalVisibility
        {
            get => categories[3];
            set
            {
                SetProperty(ref categories[3], value);
            }
        }

        public bool WoodVisibility
        {
            get => categories[4];
            set
            {
                SetProperty(ref categories[4], value);
            }
        }

        public bool TextileVisibility
        {
            get => categories[5];
            set
            {
                SetProperty(ref categories[5], value);
            }
        }

        public bool GlassVisibility
        {
            get => categories[6];
            set
            {
                SetProperty(ref categories[6], value);
            }
        }

        public bool CombinedVisibility
        {
            get => categories[7];
            set
            {
                SetProperty(ref categories[7], value);
            }
        }

        public bool BulkyVisibility
        {
            get => categories[8];
            set
            {
                SetProperty(ref categories[8], value);
            }
        }

        public bool DirtyVisibility
        {
            get => categories[12];
            set
            {
                SetProperty(ref categories[12], value);
            }
        }
        
        public bool DepositVisibility
        {
            get => categories[10];
            set
            {
                SetProperty(ref categories[10], value);
            }
        }

        public bool EWasteVisibility
        {
            get => categories[11];
            set
            {
                SetProperty(ref categories[11], value);
            }
        }

        public bool ContaminatedVisibility
        {
            get => categories[9];
            set
            {
                SetProperty(ref categories[9], value);
            }
        }



        public string ItemDescription
        {
            get => item.description;
            set
            {
                var temp = item.description;
                SetProperty(ref temp, value);
                item.description = temp;
            }
        }
        public string ItemName
        {
            get => item.name;
            set
            {
                var temp = item.name;
                SetProperty(ref temp, value);
                item.name = temp;
            }
        }

        public string ItemImage
        {
            get => item.img;
            set
            {
                var temp = item.img;
                SetProperty(ref temp, value);
                item.img = temp;
            }
        }
        
        
    }
}
