using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CategoryAdded = " Kategori başarılı bir şekilde eklenmiştir. ";
        public static string CategoryUpdated = " Kategori başarılı bir şekilde güncellenmiştir. ";
        public static string CategoryDeleted = " Kategori başarılı bir şekilde silinmiştir. ";
        public static string AuthorizationDenied = "Bu işlemi yapabilmeniz için yetkiniz bulunmamaktadır. ";
        public static string UserRegistered = " Başarılı bir şekilde üye olunmuştur. ";
        public static string UserNotFound = " Böyle bir kullanıcı bulunamadı. ";
        public static string PasswordError = "Hatalı şifre girilmiştir. ";
        public static string SuccessfulLogin = " Giriş başarılı. ";
        public static string UserAlreadyExists = " Böyle bir kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        internal static string productAdded = " Ürün başarılı bir şekilde eklenmiştir. ";
        internal static string productUpdated = " Ürün başarılı bir şekilde güncellenmiştir. ";
        internal static string productDeleted = " Ürün başarılı bir şekilde silinmiştir. ";
        internal static string OrderDeleted = " Siparişiniz silindi. ";
        internal static string OrderAdded = " Siparişiniz eklendi. ";
        internal static string OrderUpdated = " Siparişiniz güncellendi. ";
    }
}
