using KozlovAppV2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KozlovAppV2.ViewModel
{
    public class ProductsVM : INotifyPropertyChanged
    {
        User13Context db;
        IEnumerable<Product> products;
        private List<string> productManufacture;
        public IEnumerable<Product> Products
        {
            get { return products; }
            set 
            { 
                products = value; 
                OnPropertyChanged(nameof(Products));
            }
        }

        public ProductsVM()
        {
            db = new User13Context();
            db.Products.Load();
            Products = db.Products.Local.ToBindingList();
            productManufacture = products.Select(x=>x.ProductManufacturer).ToList();
            productManufacture = productManufacture.Distinct(new PartialComparer()).ToList(); // Как работает я хз, но работает!!!
            // Взял отсюда https://ru.stackoverflow.com/questions/424590/liststring-%D0%B2%D0%B7%D1%8F%D1%82%D1%8C-%D1%83%D0%BD%D0%B8%D0%BA%D0%B0%D0%BB%D1%8C%D0%BD%D1%8B%D0%B5-%D0%B7%D0%BD%D0%B0%D1%87%D0%B5%D0%BD%D0%B8%D0%B5?ysclid=lepkjaiqsi8831747
        }

        private string selectedSortByAscDesc = "";
        private string findUnit = "";
        private string selectedManufacture = "";

        private RelayCommand addPhotos;

        public RelayCommand AddPhotos
        {
            get
            {
                return addPhotos ?? (addPhotos = new RelayCommand((obj)=>
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.InitialDirectory = "";
                    dlg.Filter = "Img files (*.png) | *.png";
                    if (dlg.ShowDialog() == true)
                    {
                        string selectedFileName = dlg.FileName;
                        //ImageToByteArray(selectedFileName);
                    }
                }));
            }
        }

        public string SelectedManufacture
        {
            get => selectedManufacture;
            set
            {
                selectedManufacture = value; 

                Products = db.Products.Where(x=>x.ProductManufacturer == selectedManufacture).ToList();
            }
        }

        public List<string> ProductManufacture
        {
            get => productManufacture;
            set
            {
                productManufacture = value;
            }
        }

        public string SelectedSortByAscDesc
        {
            get => selectedSortByAscDesc;
            set
            {
                selectedSortByAscDesc = value;

                if (selectedSortByAscDesc.Contains("Все"))
                {
                    db.Products.LoadAsync();
                    Products = db.Products.Local.ToBindingList();
                }
                else if (selectedSortByAscDesc.Contains("По убыванию"))
                    Products = Products.OrderByDescending(x => x.ProductQuantityInStock).ToList();
                else if (selectedSortByAscDesc.Contains("По возрастанию"))
                    Products = Products.OrderBy(x => x.ProductQuantityInStock).ToList();
                else if (selectedSortByAscDesc.Contains("По стоимости"))
                    Products = Products.OrderBy(x => x.ProductCost).ToList();
            }
        }

        public string FindUnit
        {
            get => findUnit;
            set
            {
                findUnit = value;
                Products = products.Where(x => x.ProductName.Contains(findUnit)).ToList();
                if (findUnit == "")
                {
                    db.Products.LoadAsync();
                    Products = db.Products.Local.ToBindingList();
                }
            }
        }

        public byte[] ImageToByteArray(BitmapSource imageIn)
        {
            using (var ms = new MemoryStream())
            {
                var encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(imageIn));
                encoder.Save(ms);
                return ms.ToArray();
            }
        }

       public BitmapImage BytesToImg(byte[] ImgBytes)
        {
            using (var ms = new MemoryStream())
            {
               var img = new BitmapImage();
               img.BeginInit();
               img.CacheOption= BitmapCacheOption.OnLoad;
                img.StreamSource = ms;
                img.EndInit();
                return img;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = " ")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
