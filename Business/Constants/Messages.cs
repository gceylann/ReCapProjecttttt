using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Invalid = "Geçersiz";
        public static string Success = "işlem Başarılı";
        public static string CarPriceInvalid = "Ürün fiyatı geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string Listed= "Listelendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string UserNameInvalid = "Kullanıcı adı en az 2 karakter olmalıdır";
        public static string CarImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir. ";
        internal static string AuthorizationDenied="Yetkiniz yok.";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string CardIsExists="Kart tanımlı";
        public static string NotListed="Listelenemedi";
        public static string WrongPassword="Şifre Yanlış";
        public static string CarIsAlreadyRented="Araç kiralanmış";
        public static string FindeksScoreIsNotEnough="Findeks Skorunuz Yeterli Değil";
    }
}
