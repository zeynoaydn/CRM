using Business.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{

    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string ProductUpdated = "ürün güncellendi";
        public static string ProductDeleted = "ürün silindi";
        public static string productdeleted = " ürün silindi";
        public static string UserNotFound = "kullanıcı  bulunamadı";
        public static string PasswordError = "şifre hatalı";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExits = "kullanıcı  hazır";
        public static string UserSuccessLogin = "kullanıcı  girişi başarılı";
        public static string AccessTokenCreated = "token oluşturuldu";
        public static string UserRegistered = "kullanıcı girişi yapıldı";
        public static string UserAlreadyExists = "kullanıcı hazır";
        public static string CountriesListed = "ülkeler listelendi";
        public static string CitiesListed = "şehirler listelendi";
        public static string ProductNotFound = "ürün bulunamadı zeynomm";
        public static string CountryNameAlreadyExists = "ülke ismi zaten var";
        public static string CountryDeleted = "ülke ismi silindi";
        public static string CountryUpdated = "ülke ismi güncellendi";
        public static string CountryAdde = "ülke eklendi";
        public static string CountryAdded = "ülke eklendi";
        public static string CityAdded = "şehir eklendi";
        public static string CityNameAlreadyExists = "şehir zaten ekli";
        public static string CityDeleted = "şehir silindi";
        public static string CityUpdated = "şehir güncellendi";

        public static string CountriesAddes { get; internal set; }
    }
}
