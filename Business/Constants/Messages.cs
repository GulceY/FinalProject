using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün Adı Geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Ürün sayısı aştınız.";
        public static string ProductNameInvalidAlreadyExists="Ürün ismi önceden kullanılmıştır.";
        public static string CategoryError="Daha Fazla Kategory Eklenemez";
    }
}
